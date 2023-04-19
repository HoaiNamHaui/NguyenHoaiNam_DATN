using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Enitites.DTO
{
    public class ServiceResult
    {
        /// <summary>
        /// Thành công
        /// </summary>
        public bool IsSuccess { get; set; }

        /// <summary>
        /// Id bản ghi đã thêm
        /// </summary>
        public Guid Id { get; set; }

        /// <summary>
        /// Mã lỗi
        /// </summary>
        public int? ErrorCode { get; set; }

        /// <summary>
        /// Thông tin thêm
        /// </summary>
        public object Data { get; set; }

        /// <summary>
        /// Thông báo
        /// </summary>
        public string message { get; set; }
    }
}
