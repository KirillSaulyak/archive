'use client'

import { DatePicker as DatePickerMUI, LocalizationProvider } from "@mui/x-date-pickers-pro";
import { AdapterDateFns } from "@mui/x-date-pickers/AdapterDateFns";

import ruLocale from 'date-fns/locale/ru';
import { format } from 'date-fns';


export default function DatePicker({ label, onChange, oldValue }) {
    return (
        <LocalizationProvider
            dateAdapter={AdapterDateFns}
            adapterLocale={ruLocale}
        >
            <DatePickerMUI
                label={label}
                value={new Date(oldValue)}
                views={['year', 'month', 'day']}
                dateFormat="yyyy-MM-dd"
                sx={{ width: 250 }}
                onChange={(value) => onChange(format(value, 'yyyy-MM-dd'))}
            />
        </LocalizationProvider>
    )
}