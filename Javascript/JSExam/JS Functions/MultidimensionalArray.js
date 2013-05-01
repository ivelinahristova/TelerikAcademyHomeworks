function newMultiArray(rows, cols) {
    var matrix = [];
    var i = 0;
    var j = 0;

    for (i = 0; i < rows; i++) {

        matrix[i] = new Array(rows);

        for (j = 0; j < cols; j++) {
            matrix[i][j] = 0;
        }
    }

    return matrix;
}