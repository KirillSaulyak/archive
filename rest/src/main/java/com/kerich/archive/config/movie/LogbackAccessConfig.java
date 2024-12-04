package com.kerich.archive.config.movie;

import ch.qos.logback.access.tomcat.LogbackValve;
import org.springframework.boot.web.embedded.tomcat.TomcatServletWebServerFactory;
import org.springframework.boot.web.server.WebServerFactoryCustomizer;
import org.springframework.context.annotation.Bean;
import org.springframework.context.annotation.Configuration;

@Configuration
public class LogbackAccessConfig {
    @Bean
    public WebServerFactoryCustomizer<TomcatServletWebServerFactory> accessLogValveCustomizer() {
        return factory -> factory.addContextValves(createLogbackValve());
    }
    private LogbackValve createLogbackValve() {
        LogbackValve logbackValve = new LogbackValve();
        logbackValve.setFilename("logback-access.xml");
        logbackValve.setAsyncSupported(true);
        return logbackValve;
    }
}
