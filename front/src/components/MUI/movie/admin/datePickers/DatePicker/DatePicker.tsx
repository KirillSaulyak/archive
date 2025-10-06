"use client";

import { DatePicker as DatePickerMUI, LocalizationProvider } from "@mui/x-date-pickers-pro";
import { AdapterDateFns } from "@mui/x-date-pickers/AdapterDateFns";

import ruLocale from "date-fns/locale/ru";
import { format } from "date-fns";

import { Props } from "./structure";

const DatePicker = ({ label, oldValue, onChange }: Props) => {
  return (
    <LocalizationProvider dateAdapter={AdapterDateFns} adapterLocale={ruLocale}>
      <DatePickerMUI
        label={label}
        value={oldValue ? new Date(oldValue) : null}
        views={["year", "month", "day"]}
        sx={{ width: 250 }}
        onChange={(value) => {
          if (value) {
            onChange(new Date(format(value, "yyyy-MM-dd")));
          }
        }}
      />
    </LocalizationProvider>
  );
};

export default DatePicker;
