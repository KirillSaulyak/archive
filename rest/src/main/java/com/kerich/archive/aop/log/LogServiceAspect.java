package com.kerich.archive.aop.log;

import lombok.extern.slf4j.Slf4j;
import org.aspectj.lang.JoinPoint;
import org.aspectj.lang.annotation.AfterReturning;
import org.aspectj.lang.annotation.Aspect;
import org.aspectj.lang.annotation.Before;
import org.aspectj.lang.annotation.Pointcut;
import org.aspectj.lang.reflect.MethodSignature;
import org.springframework.stereotype.Component;

@Aspect
@Component
@Slf4j
public class LogServiceAspect {
    @Pointcut("execution(public * com.kerich.archive.service..*(..))")
    private void serviceLayerExecutionPointcut() {
    }

    @Before("serviceLayerExecutionPointcut()")
    public void logBeforeService(JoinPoint joinPoint) {
        MethodSignature methodSignature = (MethodSignature) joinPoint.getSignature();
        Object[] args = joinPoint.getArgs();
        String[] parameterNames = methodSignature.getParameterNames();
        log.atInfo()
                .addKeyValue("status", StatusMethod.STARTED)
                .addKeyValue("class", methodSignature.getDeclaringTypeName())
                .addKeyValue("method", methodSignature.getName())
                .addKeyValue("parameters", args)
                .addArgument(methodSignature.getDeclaringTypeName())
                .addArgument(methodSignature.getName())
                .addArgument(parameterNames.length > 0 ? parameterNames : "")
                .log("Started method execution {}.{}({})");
    }

    @AfterReturning(pointcut = "serviceLayerExecutionPointcut()", returning = "returningResult")
    public void logAfterReturningService(JoinPoint joinPoint, Object returningResult) {
        MethodSignature methodSignature = (MethodSignature) joinPoint.getSignature();
        log.atInfo()
                .addKeyValue("status", StatusMethod.SUCCESSFUL)
                .addKeyValue("class", methodSignature.getDeclaringTypeName())
                .addKeyValue("method", methodSignature.getName())
                .addKeyValue("returning type", methodSignature.getReturnType())
                .addKeyValue("returning", returningResult)
                .addArgument(methodSignature.getDeclaringTypeName())
                .addArgument(methodSignature.getName())
                .log("Successful method execution {}.{}");
    }
}
