namespace WsBlazorCrud.Models.Response {
    public class DefaultResponse {

        public int Success { get; set; }
        public int Failure { get; set; }
        public string Message { get; set; }
        public object Data { get; set; }

        public DefaultResponse() {
            this.Success = 0;
        }
    }
}
