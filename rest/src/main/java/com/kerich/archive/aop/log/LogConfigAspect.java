package com.kerich.archive.aop.log;

import lombok.extern.slf4j.Slf4j;
import org.aspectj.lang.JoinPoint;
import org.aspectj.lang.annotation.AfterReturning;
import org.aspectj.lang.annotation.Aspect;
import org.aspectj.lang.annotation.Before;
import org.aspectj.lang.annotation.Pointcut;
import org.springframework.stereotype.Component;

@Aspect
@Component
@Slf4j
public class LogConfigAspect {
    @Pointcut("includeLayerExecution() && !excludeLayerExecution()")
    private void layerExecution() {
    }

    @Pointcut("includeConfig()")
    private void includeLayerExecution() {
    }

    @Pointcut("excludeObjectsToSerializer()")
    private void excludeLayerExecution() {
    }

    @Pointcut("execution(public * com.kerich.archive.config..*(..))")
    private void includeConfig() {
    }

    @Pointcut("execution(public * com.kerich.archive.config.movie.jsonSerializerConfig.objectsToSerializer..*(..))")
    private void excludeObjectsToSerializer() {
    }

    @Before("layerExecution()")
    public void logBeforeInitializationConfig(JoinPoint joinPoint) {
        log.atInfo()
                .addKeyValue("class", joinPoint.getSignature().getDeclaringTypeName())
                .addArgument(joinPoint.getSignature().getDeclaringTypeName())
                .log("Started initialization configuration {}");
    }

    @AfterReturning(pointcut = "layerExecution()")
    public void logAfterReturningInitializationConfig(JoinPoint joinPoint) {
        log.atInfo()
                .addKeyValue("class", joinPoint.getSignature().getDeclaringTypeName())
                .addArgument(joinPoint.getSignature().getDeclaringTypeName())
                .log("Successful initialization configuration {}");
    }
}
