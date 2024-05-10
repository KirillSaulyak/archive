import { default as ContainerMUI } from '@mui/material/Container';

const Container = ({ children }) => {
    return (
        <ContainerMUI>
            {children}
        </ContainerMUI>
    )
}

export default Container;