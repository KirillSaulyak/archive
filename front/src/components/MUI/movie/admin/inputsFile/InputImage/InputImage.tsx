import Button from "@mui/material/Button";
import UploadIcon from "@mui/icons-material/Upload";
import Grid from "@mui/material/Grid";

import { useState, useEffect, createRef } from "react";

import Image from "next/image";

import { GeneralProps } from "../structure";

const InputImage = ({ onChange }: GeneralProps) => {
  const imgDefault = "/poster.jpeg";

  const [imgURL, setImgURL] = useState(imgDefault);

  const inputFileRef = createRef<HTMLInputElement>();

  const canRevokeObjectURL = () => imgURL && imgURL !== imgDefault;

  useEffect(() => {
    return () => {
      if (canRevokeObjectURL()) {
        URL.revokeObjectURL(imgURL);
      }
    };
  }, [imgURL]);

  const handleButtonClick = () => {
    inputFileRef.current?.click();
  };

  const changePreview = (poster: File) => {
    if (canRevokeObjectURL()) {
      URL.revokeObjectURL(imgURL);
    }
    setImgURL(URL.createObjectURL(poster));
  };

  const onChangeHandler = (event: React.ChangeEvent<HTMLInputElement>) => {
    const poster = event.target?.files?.[0];
    if (poster) {
      changePreview(poster);
      onChange(poster);
    }
  };

  return (
    <Grid container columnGap={3} rowGap={3}>
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
        <input type="file" accept="image/*" ref={inputFileRef} onChange={onChangeHandler} hidden />
      </Grid>

      <Grid>
        <Image src={imgURL} alt={"Preview"} height={180} width={150} />
      </Grid>
    </Grid>
  );
};

export default InputImage;
