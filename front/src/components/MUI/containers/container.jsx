import { default as ContainerMUI } from '@mui/material/Container';

export default function Container({ children }) {
    return (
        <ContainerMUI>
            {children}
        </ContainerMUI>
    )
}