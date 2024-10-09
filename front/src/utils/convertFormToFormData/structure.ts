export type ConvertFormToFormData = <Form extends object>(form: Form, fileFields: string[]) => FormData;
