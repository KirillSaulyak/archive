import { Dispatch, SetStateAction } from "react";
export type HandleInputChange = <T extends object>(
  setForm: Dispatch<SetStateAction<T>>
) => <K extends keyof T>(variableName: K) => (newValue: T[K]) => void;
