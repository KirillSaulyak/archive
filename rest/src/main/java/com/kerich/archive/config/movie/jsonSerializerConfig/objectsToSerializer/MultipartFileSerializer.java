package com.kerich.archive.config.movie.jsonSerializerConfig.objectsToSerializer;

import com.fasterxml.jackson.core.JsonGenerator;
import com.fasterxml.jackson.databind.SerializerProvider;
import com.fasterxml.jackson.databind.ser.std.StdSerializer;
import org.springframework.web.multipart.MultipartFile;

import java.io.IOException;

public class MultipartFileSerializer extends StdSerializer<MultipartFile> {
    public MultipartFileSerializer() {
        super(MultipartFile.class);
    }

    @Override
    public void serialize(MultipartFile file, JsonGenerator gen, SerializerProvider provider) throws IOException {
        gen.writeStartObject();

        gen.writeStringField("file.contentType", file.getContentType());
        gen.writeNumberField("file.size", file.getSize());

        gen.writeEndObject();
    }
}
