'use client'

import { DatePicker } from "@mui/x-date-pickers-pro";
import { LocalizationProvider } from '@mui/x-date-pickers-pro'
import ruLocale from 'date-fns/locale/ru';
import { AdapterDateFns } from "@mui/x-date-pickers/AdapterDateFns";

export default function DataPicker() {

    return (
        <LocalizationProvider dateAdapter={AdapterDateFns} adapterLocale={ruLocale}>
            <DatePicker label="Дата выхода" views={['year', 'month', 'day']} sx={{ width: 200 }} />
        </LocalizationProvider>
    )
}