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
    @Pointcut("includeLayerExecutionPointcut() && !excludeLayerExecutionPointcut()")
    private void layerExecutionPointcut() {
    }

    @Pointcut("includeConfigPointcut()")
    private void includeLayerExecutionPointcut() {
    }

    @Pointcut("excludeObjectsToSerializerPointcut()")
    private void excludeLayerExecutionPointcut() {
    }

    @Pointcut("execution(public * com.kerich.archive.config..*(..))")
    private void includeConfigPointcut() {
    }

    @Pointcut("execution(public * com.kerich.archive.config.movie.jsonSerializerConfig.objectsToSerializer..*(..))")
    private void excludeObjectsToSerializerPointcut() {
    }

    @Before("layerExecutionPointcut()")
    public void logBeforeInitializationConfig(JoinPoint joinPoint) {
        log.atInfo()
                .addKeyValue("status", StatusMethod.STARTED)
                .addKeyValue("class", joinPoint.getSignature().getDeclaringTypeName())
                .addArgument(joinPoint.getSignature().getDeclaringTypeName())
                .log("Started initialization configuration {}");
    }

    @AfterReturning(pointcut = "layerExecutionPointcut()")
    public void logAfterReturningInitializationConfig(JoinPoint joinPoint) {
        log.atInfo()
                .addKeyValue("status", StatusMethod.SUCCESSFUL)
                .addKeyValue("class", joinPoint.getSignature().getDeclaringTypeName())
                .addArgument(joinPoint.getSignature().getDeclaringTypeName())
                .log("Successful initialization configuration {}");
    }
}
