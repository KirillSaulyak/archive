export interface Props {
  label: string;
  onChange: (value: Date) => void;
  oldValue: Date | undefined;
}
