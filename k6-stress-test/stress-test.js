import http from 'k6/http';
import {sleep, check} from 'k6';

export const options = {
  stages: [
    { duration: '2m', target: 2000 },
    { duration: '1m', target: 0 },
  ],
};

export default () => {
  const responseGetAll = http.get('http://localhost:5000/Announcement');
  check(responseGetAll, {
    'GetAll ok': (r) => r.status === 200,
  });
  sleep(1);
};
