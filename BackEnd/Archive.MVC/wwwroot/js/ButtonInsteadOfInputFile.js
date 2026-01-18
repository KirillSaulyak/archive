function buttonInsteadOfInputFile(buttonId, inputFileId) {
    document.getElementById(buttonId).addEventListener('click', function () {
        document.getElementById(inputFileId).click();
    });
}
