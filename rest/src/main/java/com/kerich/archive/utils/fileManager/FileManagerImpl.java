package com.kerich.archive.utils.fileManager;


import org.springframework.beans.factory.InitializingBean;
import org.springframework.beans.factory.annotation.Value;
import org.springframework.stereotype.Component;
import org.springframework.web.multipart.MultipartFile;

import java.io.IOException;
import java.io.InputStream;
import java.nio.file.FileAlreadyExistsException;
import java.nio.file.Files;
import java.nio.file.Path;
import java.util.UUID;

import static java.util.Objects.requireNonNull;

@Component
public class FileManagerImpl implements InitializingBean, FileManager {
    @Value("${file.upload-path.poster}")
    private Path posterPath;

    @Override
    public void afterPropertiesSet() {
        try {
            if (Files.notExists(posterPath)) {
                createDirectories(posterPath);
            }
        } catch (IOException e) {
            System.out.println(e);
        }

    }

    @Override
    public Path savePoster(MultipartFile poster) throws IOException {
        try {
            return saveFile(poster, posterPath);
        } catch (IOException exception) {
            throw new IOException("Can`t save poster: ", exception);
        }
    }

    @Override
    public void deleteFile(Path pathToFile) throws IOException {
        if (Files.notExists(pathToFile)) {
            throw new IOException("File does not exist: " + pathToFile);
        }

        try {
            Files.delete(pathToFile);
        } catch (IOException exception) {
            throw new IOException("Can`t delete file with this path: " + pathToFile, exception);
        }
    }

    private void createDirectories(Path directory) throws IOException {
        try {
            Files.createDirectories(directory);
        } catch (IOException exception) {
            throw new IOException("Can`t create directory: " + directory, exception);
        }
    }

    private String getNewFileName(String oldName) {
        requireNonNull(oldName, "File name is null");

        int extensionStartIndex = oldName.lastIndexOf('.');
        if (extensionStartIndex == -1) {
            throw new IllegalArgumentException("Old file name hasn`t extension");
        }
        return UUID.randomUUID() + oldName.substring(extensionStartIndex);

    }

    private Path saveFile(MultipartFile file, Path directoriesPath) throws IOException {
        String newFileName = getNewFileName(file.getOriginalFilename());
        Path filePath = directoriesPath.resolve(newFileName);
        try (InputStream inputStream = file.getInputStream()) {
            Files.copy(inputStream, filePath);
        } catch (FileAlreadyExistsException exception) {
            throw new FileAlreadyExistsException("File already exists with name: " + newFileName);
        }
        return filePath;
    }
}
