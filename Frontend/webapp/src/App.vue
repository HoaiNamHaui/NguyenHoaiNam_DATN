<template>
<div class="container">
  <!-- <the-header />
  <div style="display: flex;">
    <the-sidebar />
    <the-content />
  </div> -->
  <customer-vue />
</div>
</template>

<script>
import CustomerVue from './Customer.vue'
// import TheHeader from './components/layout/TheHeader.vue'
// import TheSidebar from './components/layout/TheSidebar.vue'
// import TheContent from './components/layout/TheContent.vue'
export default {
  name: 'App',
  components: {
    // TheHeader,
    // TheSidebar,
    // TheContent
    CustomerVue,
  }
}
</script>

<style>
@import url(./css/main.css);
</style>
