import Toolbar from "@mui/material/Toolbar";
import AppBar from "@mui/material/AppBar";
import Button from "@mui/material/Button";

const NavBar = () => {
  return (
    <>
      <AppBar color="inherit" position="relative" sx={{ mb: 2 }}>
        <Toolbar>
          <Button color="inherit">фильмы</Button>
          <Button color="inherit">Сериалы</Button>
          <Button color="inherit">Мультфильмы</Button>
          <Button color="inherit">Аниме</Button>
          <Button color="inherit">Выход</Button>
        </Toolbar>
      </AppBar>
    </>
  );
};

export default NavBar;
