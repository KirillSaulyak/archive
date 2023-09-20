import Button from "@mui/material/Button";
import Grid from '@mui/material/Unstable_Grid2';
import Image from 'next/image'
import UploadIcon from '@mui/icons-material/Upload';
import React from "react";
import DefaultRow from "../grids/Row";
export default function InputImage() {
    const inputFileRef = React.createRef<HTMLInputElement>();

    const handleButtonClick = () => {
        inputFileRef.current?.click();

    };

    const [imgURL, setImgURL] = React.useState("/poster.jpeg");

    const changePreview = () => {
        const file = inputFileRef.current?.files?.[0];
        if (file) {
            setImgURL(URL.createObjectURL(file))
        }
    }

    return (
        <>
            <Grid container columnGap={3} rowGap={3}>
                <Grid>
                    <Button size="medium"
                        onClick={() => handleButtonClick()}
                        variant="contained"
                        color="inherit"
                        endIcon={<UploadIcon fontSize="large" />}
                    >
                        Добавить постер
                    </Button>
                    <input type="file"
                        accept="image/*"
                        ref={inputFileRef}
                        onChange={() => changePreview()}
                        hidden
                    />
                </Grid>
                <Grid>
                    <Image src={imgURL} alt={"Preview"} height={180} width={150} />
                </Grid>
            </Grid>
        </>
    )
}