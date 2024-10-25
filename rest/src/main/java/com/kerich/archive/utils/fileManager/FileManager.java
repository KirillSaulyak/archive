package com.kerich.archive.utils.fileManager;

import org.springframework.web.multipart.MultipartFile;

import java.io.IOException;
import java.nio.file.Path;

public interface FileManager {
    Path savePoster(MultipartFile poster) throws IOException;
    void deleteFile(Path pathToFile) throws IOException;
}
