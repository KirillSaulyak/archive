import Grid from '@mui/material/Unstable_Grid2';
import Tabs from '@mui/material/Tabs';
import Tab from '@mui/material/Tab';
import LogoutIcon from '@mui/icons-material/Logout';
import Toolbar from '@mui/material/Toolbar';
import AppBar from '@mui/material/AppBar';
import IconButton from '@mui/material/IconButton';
import Typography from '@mui/material/Typography';
import MenuIcon from '@mui/icons-material/Menu';
import Button from '@mui/material/Button';
export default function NavBar() {
  return (
  
        <AppBar  color="inherit" position='static'>
          <Toolbar>
            <Button color="inherit">Главная</Button>
            <Button color="inherit">О нас</Button>
            <Button color="inherit">Контакты</Button>
            <Button color="inherit">Выход</Button>
          </Toolbar>
        </AppBar>
    
  )
}
