import Axios from 'axios';

const apiUrl = 'http://localhost:50299/Api';
const performanceUrl = `${apiUrl}/Home/GetPerformance`

export function getPerformance() {
  return Axios.get(performanceUrl);
}