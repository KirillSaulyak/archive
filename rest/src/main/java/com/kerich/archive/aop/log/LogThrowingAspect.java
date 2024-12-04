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
        String[] parameterNames = methodSignature.getParameterNames();
        log.atError()
                .setCause(exception)
                .addKeyValue("class", methodSignature.getDeclaringTypeName())
                .addKeyValue("returnType", methodSignature.getReturnType())
                .addKeyValue("method", methodSignature.getName())
                .addKeyValue("parametersNames", parameterNames.length > 0 ? parameterNames : "")
                .addKeyValue("parameters", args.length != 0 ? args : "()")
                .addKeyValue("exceptionMessage", exception.getMessage())
                .addArgument(methodSignature.getDeclaringTypeName())
                .addArgument(methodSignature.getName())
                .log("Exception in {}.{}");
    }
}
