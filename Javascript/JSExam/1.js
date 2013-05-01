function Solve(args){
    var number = parseInt(args[0]);
    var array = [];
    var startIndex = 0;
    var endIndex = 0;
    
     for (var i = 0; i < number; i++) {
        array[i] = parseInt(args[i + 1]);
    }
    var sum = array[0];
    var maxSum = sum;
    var finalSum = sum;
    for (var i = 0; i < number; i++) {
        sum = 0;
        for (var j = i; j < number; j++) {
            sum += array[j];
            if (sum>maxSum) {
                maxSum = sum;
                startIndex = i;
                endIndex = j;
            }

        }
    }
    finalSum = 0;
    for (var i = startIndex; i <= endIndex; i++) {
        finalSum += array[i];
    }
   return finalSum;

}

function HandleSolveIO(){
	var args = [];
	args = ["8", "1", "6", "-9", "4", "4", "-2", "10", "-1"];
	console.log(Solve(args));
}
HandleSolveIO();