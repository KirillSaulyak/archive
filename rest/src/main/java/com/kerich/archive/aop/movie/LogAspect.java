package com.kerich.archive.aop.movie;

import lombok.extern.slf4j.Slf4j;
import org.aspectj.lang.JoinPoint;
import org.aspectj.lang.annotation.*;
import org.aspectj.lang.reflect.MethodSignature;
import org.springframework.stereotype.Component;

import java.util.Arrays;

@Aspect
@Component
@Slf4j
public class LogAspect {

    @Before("serviceLayerExecution()")
    public void logBeforeServiceAdvice(JoinPoint joinPoint) {
        logBefore(joinPoint);
    }

    @AfterReturning(pointcut = "serviceLayerExecution()", returning = "returningResult")
    public void logAfterReturningServiceAdvice(JoinPoint joinPoint, Object returningResult) {
        logAfterReturning(joinPoint, returningResult);
    }

    @Before("controllerLayerExecution()")
    public void logBeforeControllerAdvice(JoinPoint joinPoint) {
        logBefore(joinPoint);
    }

    @AfterReturning(pointcut = "controllerLayerExecution()", returning = "returningResult")
    public void logAfterReturningControllerAdvice(JoinPoint joinPoint, Object returningResult) {
        logAfterReturning(joinPoint, returningResult);
    }

    @AfterThrowing(pointcut = "execution(* com.kerich.archive..*(..))", throwing = "exception")
    public void logAfterThrowing(JoinPoint joinPoint, Throwable exception) {
        MethodSignature methodSignature = (MethodSignature) joinPoint.getSignature();
        log.error("In: {}.{}({})", methodSignature.getDeclaringTypeName(), methodSignature.getName(), joinPointArgsToString(joinPoint.getArgs()), exception);
    }

    @Pointcut("execution(public * com.kerich.archive.service..*(..))")
    private void serviceLayerExecution() {
    }

    @Pointcut("execution(public * com.kerich.archive.controller..*(..))")
    private void controllerLayerExecution() {
    }

    private String joinPointArgsToString(Object[] joinPoint) {
        return String.join(", ", Arrays.stream(joinPoint)
                .map(Object::toString)
                .toArray(String[]::new));
    }

    private void logBefore(JoinPoint joinPoint) {
        MethodSignature methodSignature = (MethodSignature) joinPoint.getSignature();
        log.info("Began doing: {}.{}({})", methodSignature.getDeclaringTypeName(),
                methodSignature.getName(),
                joinPointArgsToString(joinPoint.getArgs()));
    }

    private void logAfterReturning(JoinPoint joinPoint, Object returningResult) {
        MethodSignature methodSignature = (MethodSignature) joinPoint.getSignature();
        log.info("Success finished: {}.{} with returning: ({})",
                methodSignature.getDeclaringTypeName(),
                methodSignature.getName(),
                methodSignature.getReturnType() == void.class ? "void" : returningResult);
    }
}
