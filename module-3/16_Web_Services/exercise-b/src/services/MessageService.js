import axios from 'axios';

const http = axios.create({
  baseURL: "http://localhost:3000"
});

export default {

  get(id) {
    return http.get(`/messages/${id}`);
  },
  addMessage(message) {
    return http.post('/messages', message);
  },
  changeMessage(messageId, message) {
    return http.put('/messages/' + messageId, message);
  },
  removeMessage(topicId) {
    return http.delete('/messages/' + topicId)
  }


}
