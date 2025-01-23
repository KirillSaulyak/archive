package com.kerich.archive.aop.log;

import lombok.extern.slf4j.Slf4j;
import org.aspectj.lang.JoinPoint;
import org.aspectj.lang.annotation.AfterThrowing;
import org.aspectj.lang.annotation.Aspect;
import org.aspectj.lang.reflect.MethodSignature;
import org.springframework.stereotype.Component;

@Aspect
@Component
@Slf4j
public class LogThrowingAspect {
    @AfterThrowing(pointcut = "execution(* com.kerich.archive..*(..))", throwing = "exception")
    public void logAfterThrowing(JoinPoint joinPoint, Throwable exception) {
        MethodSignature methodSignature = (MethodSignature) joinPoint.getSignature();
        Object[] args = joinPoint.getArgs();
        log.atError()
                .setCause(exception)
                .addKeyValue("class", methodSignature.getDeclaringTypeName())
                .addKeyValue("method", methodSignature.getName())
                .addKeyValue("parameters", args)
                .addKeyValue("exceptionMessage", exception.getMessage() == null ? "No message available" : exception.getMessage())
                .addKeyValue("status", StatusMethod.ERROR)
                .addArgument(methodSignature.getDeclaringTypeName())
                .addArgument(methodSignature.getName())
                .log("Exception in {}.{}");
    }
}
