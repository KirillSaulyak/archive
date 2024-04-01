
interface options {
    id: number;
    name: string;
  }

export interface autocompleteProps {
    options: options[],
    optionLabel:string,
    label: string,
    onClick:(event: React.MouseEvent<HTMLElement>) => void,
}