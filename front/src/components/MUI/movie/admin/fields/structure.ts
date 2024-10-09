export interface GeneralProps {
  autoFocus?: boolean;
  label: string;
  oldValue: string | undefined;
  onChange: (value: string) => void;
}
