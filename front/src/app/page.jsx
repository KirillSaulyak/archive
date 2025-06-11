'use client'
import Container from '@mui/material/Container';
import Grid from '@mui/material/Unstable_Grid2';
import Typography from '@mui/material/Typography';
import Card from '@mui/material/Card';
import CardContent from '@mui/material/CardContent';
import CardMedia from '@mui/material/CardMedia';
import { CardActionArea } from '@mui/material';
import Link from 'next/link';

export default function MainPage({ store }) {
    const images = [
        {
            id: 1,
            img: 'https://images.unsplash.com/photo-1522770179533-24471fcdba45',
            name: 'Кино',
            author: '@helloimnik',
        },
        {
            id: 2,
            img: 'https://images.unsplash.com/photo-1551782450-a2132b4ba21d',
            name: 'Цитаты',
            author: '@rollelflex_graphy726',
        },

        {
            id: 3,
            img: 'https://images.unsplash.com/photo-1551963831-b3b1ca40c98e',
            name: 'Игры',
            author: '@bkristastucchio',
            rows: 2,
            cols: 2,
            featured: true,
        },
        {
            id: 1,
            img: 'https://images.unsplash.com/photo-1444418776041-9c7e33cc5a9c',
            name: 'Код',
            author: '@nolanissac',
            cols: 2,
            alt: "sadf"
        }
    ];

    return (
        <main>
            <Container>
                <Grid
                    container
                    justifyContent="center"
                    mt={3}
                    columnGap={9}
                    rowGap={3}
                >
                    {
                        images.map((img) => (

                            <Grid>
                                <Link href={"/movie/admin"} passHref store={store}>
                                    <Card sx={{ maxWidth: 345 }} key={img.id}>
                                        <CardActionArea>
                                            <CardMedia
                                                component="img"
                                                height="140"
                                                image={`${img.img}?w=248&fit=crop&auto=format`}
                                                alt={img.alt}
                                            />
                                            <CardContent>
                                                <Typography gutterBottom variant="h5" component="div">
                                                    {img.name}
                                                </Typography>
                                            </CardContent>
                                        </CardActionArea>
                                    </Card>
                                </Link>
                            </Grid>
                        ))
                    }
                </Grid>
            </Container>
        </main>
    )
}
