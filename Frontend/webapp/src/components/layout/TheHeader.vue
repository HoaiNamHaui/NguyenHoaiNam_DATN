<template>
  <div class="header">
    <div class="logo">
      <img class="logo-image" src="../../assets/images/logo.png" alt="logo" />
    </div>
    <div class="header-left">
      <div class="header-item">
        <div class="header-contact-icon"><i class="fa-solid fa-phone"></i></div>
        <div>
          Gọi mua hàng <br />
          0383.871.190
        </div>
      </div>
      <div class="header-item">
        <div class="header-contact-icon"><i class="fa-solid fa-truck"></i></div>
        <div>
          Tra cứu <br />
          đơn hàng
        </div>
      </div>
      <div class="header-item">
        <div class="header-contact-icon"><i class="fa-solid fa-bag-shopping"></i></div>
        <div>
          Giỏ <br />
          hàng (0)
        </div>
      </div>
      <div class="header-login">
        <div class="header-contact-icon"><i class="fa-solid fa-user"></i></div>
        <div>
          Đăng nhập
        </div>
      </div>
    </div>
  </div>
</template>
<script>
export default {
  name: "TheHeader",
};
</script>
<style scoped>
@import url(../../css/layout/header.css);
</style>