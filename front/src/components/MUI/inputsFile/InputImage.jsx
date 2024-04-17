import Button from "@mui/material/Button";
import UploadIcon from '@mui/icons-material/Upload';

import { useState, createRef } from "react";

import { Grid } from '../grids/importsCommon';
import Image from 'next/image';

export default function InputImage({ onChange }) {

    // const inputFileRef = createRef < HTMLInputElement > ();
    const inputFileRef = createRef();
    const handleButtonClick = () => {
        inputFileRef.current?.click();

    };

    const [imgURL, setImgURL] = useState("/poster.jpeg");

    const changePreview = (poster) => {
        if (poster) {
            setImgURL(URL.createObjectURL(poster))
        }
    };

    const onChangeHandler = () => {
        const poster = inputFileRef.current?.files?.[0];
        changePreview(poster);
        onChange(poster);
    };

    return (
        <Grid
            container
            columnGap={3}
            rowGap={3}
        >
            <Grid>
                <Button
                    size="medium"
                    onClick={() => handleButtonClick()}
                    variant="contained"
                    color="inherit"
                    endIcon={<UploadIcon fontSize="large" />}
                >
                    Добавить постер
                </Button>
                <input
                    type="file"
                    accept="image/*"
                    ref={inputFileRef}
                    onChange={onChangeHandler}
                    hidden
                />
            </Grid>

            <Grid>
                <Image
                    src={imgURL}
                    alt={"Preview"}
                    height={180}
                    width={150}
                />
            </Grid>
        </Grid>
    )
}