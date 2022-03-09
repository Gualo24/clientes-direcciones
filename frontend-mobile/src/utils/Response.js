export default class Response {
    constructor(isSuccess, message, result = null, bussy = false) {
      this.isSuccess = isSuccess
      this.message = message
      this.result = result
      this.bussy = bussy
    }
  }