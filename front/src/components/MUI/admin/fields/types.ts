interface common {
    name: string,
    label: string,
    variableName: string,
    oldValue: string,
    onChange: (value: string) => void
}

export interface TextAreaProps extends common {

}

export interface TextFieldProps extends common {

}

