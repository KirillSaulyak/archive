package com.kerich.archive.config.movie.jsonSerializerConfig;

import com.fasterxml.jackson.core.JsonFactory;
import com.fasterxml.jackson.databind.ObjectMapper;
import com.fasterxml.jackson.databind.module.SimpleModule;
import com.kerich.archive.config.movie.jsonSerializerConfig.objectsToSerializer.MultipartFileSerializer;
import net.logstash.logback.decorate.JsonFactoryDecorator;
import org.springframework.web.multipart.MultipartFile;


public class JsonSerializerConfig implements JsonFactoryDecorator {

    @Override
    public JsonFactory decorate(JsonFactory factory) {
        if (factory.getCodec() instanceof ObjectMapper objectMapper) {
            SimpleModule module = new SimpleModule();
            module.addSerializer(MultipartFile.class, new MultipartFileSerializer());

            objectMapper.registerModule(module);
        }
        return factory;
    }
}
