function Solve(args){
	
    var temp = args[0].split(' ');
    var rows = parseInt(temp[0]);
    var cols = parseInt(temp[1]);
    temp = args[1].split(' ');
    var firstRow = parseInt(temp[0]);
    var firstCol = parseInt(temp[1]);
    var i, j;
    var pathMatrix = [];
    for (i = 0; i < rows; i++) {
        pathMatrix[i] = [];
        for (j = 0; j < cols; j++) {
            pathMatrix[i][j] = "";
        }
    }
    for (i = 0; i < rows; i++) {
        temp = args[2 + i];
        for (j = 0; j < cols; j++) {
            pathMatrix[i][j] = temp[j];
        }
    }
    var values = 0;

    var valueMatrix = [];
    for (i = 0; i < rows; i++) {
        valueMatrix[i] = [];
        
        for (j = 0; j < cols; j++) {
            values++;
            valueMatrix[i][j] = values;
        }
    }
    var visitedMatrix = [];
    for (i = 0; i < rows; i++) {
        visitedMatrix[i] = [];
        for (j = 0; j < cols; j++) {
            visitedMatrix[i][j] = 0;
        }
    }
    var number = 0;
    var sum = valueMatrix[firstRow][firstCol];
    var numberSteps = 1;
    while (firstCol >= 0 && firstRow >= 0 && firstCol < cols && firstRow < rows) {
            switch (pathMatrix[firstRow][firstCol]) {
                case "l":
                    {
                        if (firstCol - 1 >= 0) {
                            sum += valueMatrix[firstRow][firstCol - 1];
                            firstCol = firstCol - 1;
                            
                           
                        }
                        else {
                            return "out " + sum;
                        }
                        break;
                    }
                case "r":
                    {
                        if (firstCol + 1 <= cols-1 ) {
                            sum += valueMatrix[firstRow][firstCol + 1];
                            firstCol = firstCol + 1;
                        }
                        else {
                            return "out " + sum;
                        }
                        break;
                    }
                case "u":
                    {
                        if (firstRow - 1 >= 0) {
                            sum += valueMatrix[firstRow - 1][firstCol];
                            firstRow = firstRow - 1;
                        }
                        else {
                            return "out " + sum;
                        }
                        break;
                    }
                case "d":
                    {
                        if (firstRow + 1 <= rows - 1) {
                            sum += valueMatrix[firstRow + 1][firstCol];
                            firstRow = firstRow + 1;
                        }
                        else {
                            return "out " + sum;
                        }
                        break;
                    }
                default:

            }
            if (visitedMatrix[firstRow][firstCol] === 1) {
                return "lost " + numberSteps;
            }
            else {
                visitedMatrix[firstRow][firstCol] = 1;
                numberSteps++;
            }
       
        
    }
   return 0;

}

function HandleSolveIO(){
	var args = [];
	args = ["5 8", "0 0", "rrrrrrrd", "rludulrd", "lurlddud", "urrrldud", "ulllllll"];
	console.log(Solve(args));
}
HandleSolveIO();