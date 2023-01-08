console.log(ProcessScore(null));

function ValidateScore(score) {
  if (score > 10 || score < 0) return false;
  return true;
}

function ProcessScore(firstValidScore) {
  let score = prompt();
  if (ValidateScore(score)) {
    if (firstValidScore == null) {
      return ProcessScore(score);
    }
    var media = (firstValidScore + score) / 2;
    return `média = ${media.toFixed(2)}`;
  }
  return "nota inválida\n" + ProcessScore(firstValidScore);
}
