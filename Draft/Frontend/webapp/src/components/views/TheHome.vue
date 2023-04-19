<template>
  <div class="home-container">
    <Carousel :autoplay="2000" :wrap-around="true">
      <Slide v-for="slide in listImageSlide" :key="slide">
        <!-- <div class="carousel__item">{{ slide }}</div> -->
        <div>
            <img class="slide-image" :src="slide" alt="slide">
        </div>
      </Slide>

      <template #addons>
        <Navigation />
        <Pagination />
      </template>
    </Carousel>
  </div>
</template>
<script>
import { Carousel, Navigation, Pagination, Slide } from "vue3-carousel";
import "vue3-carousel/dist/carousel.css";
export default {
  name: "TheHome",
  components: {
    Carousel,
    Slide,
    Pagination,
    Navigation,
    
  },
  data(){
    return{
        listImageSlide: ['https://lh3.googleusercontent.com/fife/AMPSemeFDDd8FdG9g9D2sij5DBS_0_Bpt2WUH8VGNigMRuCPiwY6xw6L7nz9_YlRnl-Isvckhw87g-Hk13MH3DmuaXtnOTdrp1tOKe4hYXAGjsv3Hg_uerUJhq6EuyqHBnyvVOfXAX9XRjYdGQB--bWa7-2xDupB2V4nleaV0UhyRSD_FR5Zd3TZs74_Pq45jOqD8fxvCta9xmWWpDM-VcMyHE7qyAVN7zei0Xk88f-n0BQPw8GLe3WPYMVA-6f6AzpFSlC1Qvr1-5RWiYQCuuh3zJ0IQhVSyvxQ9gLtGWP8VzdShDZZmEfPtzuzqqxxaRYuQMF5I_5AutibLF97fWhQRpjf-5jpEBIOG4k_xlAlpJY5avV9UoQTrSvkqNm8NmcLRmkAUtNKFin9NGr2-_XDBYLWRcobflRc5-OCnAEPPWreRVmmmmnts5JqRg36I7AzfPalUDBL4J-Oo-Ci8DFl5JEi1aiR5kY15koWZw2eHQxB_6DO_JZtPgD-UISVglGp4Dx8DIb3smXp63ytdhKnf5JdqRAUIl7QkLTN8wWC1iqi4zdZwBtRxbW4ZxisM1X_gXOOlIlRr_r45Kx8UgZwQA23clZsQ1cR6u8lNAWlPBNWjIt3ufivPBCuNy9_2xW56vNGRfin9bAb38oapJ8iq9QJQgYSOvpj_eojcm_DpvYMWG5Yy96iBWTonbRV-6SeM6c_A8Xw-SADGrz5lcMOK0i46qUC1hFNm7gk6lyxrq5ZCHt9vFIeZFjeVDnqBF7dc3bAU-NIsRziAp9qMHDLaON-gQ5yyzuEuiunHU0zzIw-qHMWdAKAvZxw0l70N3TOTm-n4wdFlIF4WKuM8Oez5risz5t9TnkxOWGk1KVlZ19qNFMir8EopRU9lSOFSy7thprGboik3c72De_3fAOT_-BGesSYQ44O7gosmfI0XT6UF4ShDW_u_U-YJkr0bGLamI3qwpiPcSHZmXsRek4I8jf6mILgTkCPJN7fDL675PHd24f8hsYllVTGSxuiq4WmQjV1TrqXIcWt2Cm9WFqWhvK8ZxiV3J1lag4DjqTZP5sGu-QzrSQ-4F3RDg80p1k5rMkZ2Dj-ALEm9bQK0fMrChd5KViiGMnt-OdjiPGWRuiKtR-TS8uxFoFjTRksAxcqjTAZgPd47jp7cx1yLDWA-xr9VbUw1yUFwkMy56HVOo6usi7X9tHQGTug3K5PLTnC9DdtORGsUyc8ictrO3FQdBlPU4fp-QkzgApsgA4cPf__iI_iOSJtrT8TxmswwpQXtOzczPqZ7I05K_ogw0Ccb6-gIteESvgSE8vlD_fcOttVByY10WpA0EcUGa_7xlvn7bIizY9EqfwRpNj2td3nU2MR2arQXwSfPBcFyHuo2IXa6BjoAhZagGMjsN0buZPvO_IV-7U3vioGUb1JMK1MyRbq47sxqRz5M6Q4B6kdOtRhenQITtR2l-l-hUJPGNCyMwEsP16pxR7kqG-bBvm-DTFrcD_z=w1920-h902',
        'https://lh3.googleusercontent.com/fife/AMPSemeiU82xfwWrEnDDT7n1F_DMX7Gm-Ln_QGesHWj4PKkT7KNIffT0Ix8I_3XU1PC14cMuN3rmwykYmOovTQvqyxOk4aqO1HF_A_gCRsH8d0n27qX0lciy7mhsf3dc-9hqDU3CND7Ol4bBshwy5vprvXOe5sEfWGb0cN50AYS6FSc1CICe2UQBNmW4uG91kCzDvJOa8p8vlkhWGG_HuFgx0LVDmTgdVo0criHUoOjIxBZXbFL7pNfXEhbEM4V1ZZeErAsBVvDlZIDamZFae7XDe83kfbWTIl7LdT3Qh8BkyaVDPDDtj3OMqkGxsVENTOlJZrmCnhk1cXSDpP-B2IkPyohIvwTjNMx5sc2xo53rOXjGx8hBrD2LBkXGyTpT3uFW1cDQiiNqUSfQbFkQ9gZxxZgv24blNnDIWy4ODBnVW3cMUtY4uHDGrJltuuv2ic94m5g0-sXVG7BbpYlPzFkP8WT11l0UWmS-8i3kLjQ7Eoy04gDBEjS6kdR_7FWlk-AsIaVEn0cdfGuYdRNouuCD6-iXaphFxGU7H0xIyyO__JhKpqHratEA2ksv6Y_OjmiPuc4Vj32OsnQOd6nvQpqPv9357iRwPwz6ksnU-5yL3gts0MTWo-CZrtc5WkFojF9JCiK4p-1N-Pgc51nuA4zOcUhGiDxsTpMXDpRNAG1oDrcE0rW8UJmSpvMufBze19t_B3vebORcqnwk65PSYv2wVAf2Jq_QM7lQi0dkkoQSgKwCELy3IUSVZ9xwdkYYDUwA-zZ-OFZy2r4-k0QZio5fR9gbxR-Y8weMqrP6pzHCOSrqJRW5q3NVewUUkks9SrJA8-osh7nRjbD6gtiE0FDZYh-0ubjZmhcdssylW-zjSl29NRA1th-ptGEufrGyOWG9jTxUFObaxubH3PmSKlT2YNTOQ8l2vnjHO6wQ6909eePHcZamCgkit-9-knvSLvy4S1RxegpUbZ3NCoYoIJe-Ih3_B9iACJBP6odZUnEU7nLNMCqMSUElvTXo0foILiPLwnKD3i4QvIdmZJc7MToRu2oUQCQkeop4Ez5ELrzdZ7euiHDfaZEmQzr0eGHxLo_bULnmkAhECORaqJdLvinwEKgqja5zroWL7fze5j04sUpkUNrb-esV-6c06HxWOl1sZjfe-MUV3xn3J0XX9hs7SxTTMnLhuVZyGHBdq5kipRWykKyPYRevUMG8gTxiJ7I_gftCv4jh2cp2yJaIvzluVRoCyCx55ZVr6a4E5uuuQMDmsnuWMH6c8DSIGhiOg497bEh35hiDLsUQrT5OGqCFKrTHbvHF1pQqu8_I6RlbWvoUZOy97wOYQ3Rv3Ju2-X_f35gWlC3ME6jWI5EIqmqxJi__JSd0SdmW8NLBo2KF5YkVIAHBFOCP4ijbU4Egr1H29c5Fx1Eow6kNGe0xrNYjcnu47-zX92jJjT20j9G_RJG9MMhBdZ2G-Q0MVMXoYJjbOxv9ruZjZYUwDU29UP6RV2uRKT04=w1920-h902',
        'https://lh3.googleusercontent.com/fife/AMPSemfVRupYBkBDn0IGOhkuFEiyfPH_G3d8FT-aQUPXSKUrF_izjRdkMfbRuuyTMUZYCajXvcDWkm01r-_UVnfKk448Hx7mL7GJgc0GBa-xGzcoYAJEyNw1JhVg182vpIDhgvEc4kdoyVCDzXXIDHp4MkvelxjQ_eTkGrbZXmjMmJyr2o2Tibk0ELQY2UGsf1u58p9nJ71C9ToJi17QT_Y3vuCReLSpsioQswEDozOd66chw32Zv4M2PQRgd2rPdtyVNPd9eCXo1oYn57pZQmbpw4Y-vowUQ3X86UUEeLryFkCAd-JCEGJa9IArXPk_C5dKhwCtedUpIG6D0qerZ8mnZWU9l4zuXsHGJ_KqaN4m3NujzesLtOw0Cf3plhuaDwU9cBPHXfz3mosmHNRzJq4RDltoGTEkcxgxsJjWZd2QxDgrDrsKlNj3Q35d7UjcQkXcTen7xzYUCepcUlU_d0mOGaDvWFJb0phBYDy2v4Pjw656O-MT0aOc9pOFMXQS1Cb2IOckx_qO38BN9FUqRPI-6Gw47T-1ksbqNF0tZlyZ29pKE2eG6twHjPFV1m5Zn_AHqNV5BVB4IZMO-nwKLGor7MZ6gi7wXu_ComjgDs5l0SO8UU38L8QPmHiShbaQeQedAuotF8IxeRqmjdIOJ0yw5RtHkFJJytIK1iqBavIAstE8F6LqWem3QhUlvP61RKZPZIlSmDzJ7XJuZK_ZUYPQ1C9R3QooB0HnXiuUuv3o5uHTyKpgcnu3iIOkqCR1ZLeuGQycy1EqXERfuhP4ZJOXBzJM96Z-0RI3mQTxICynrWQf8dYtB3ZHNG-QBAeqNfbN1p5UIwEPraL4UhI9ff261vXRe9kHwZalEWZtVIp6NuNL8RXx3VAx4_BNCUrrUEeyd3G8QAh85Z1a1ov7uJjJGepRmkyMuvgg3uMkhiMVOFUPhoQPvx_ykVtvfVdV4ov1y5eH35AghAUgvsv5YrkZxSKMGELpnJTQcFlYcLfwrEhXPQSNnyrlaTprLEV3P-w72kAU4E02BkARYsMnnWvUyufha2QPsGD7PKnfHEHof09erkNQcsZU6ejcZAQnFrmBGpbjgEe9vpXrbRoCuBAFMsBnJxF09lwfHhOZnOH72-SYLM6QAElWNgfets8wzgkJ2QNW9lNr-min1Wzzwv_mBULLu5FSeBUclMhAkxGXQUGRUKbx0UN8X9B6FNTKswSZvl4yYknAEE2xbjFlBhu7nRHzRked0sQiXjKu9BQAaJ1XwGhXhrqIKmuaJnpXCIm3jpHn2o4XrT9Z9abNLO-97qrAWSrUnVaht-O0QyJC8PJlJP6w_ojSNqorC4EpUCgjCol0I4Js7GPz3zXtBkYAvSL07qniUMAzdwJbjzwLoEazkIkdvmRkJoBdeMcx-P2vF-wmuMsRIAek5zdMFVef0WfpJD-3P-SZ2niXxizNBfLkTrIvhV-vlYVhQGVmoIChw2T5TEqZk_FUWzMsfvz5IWjIX6OH=w1920-h902']
    }
  }
};
</script>

<style scoped>
@import url(../../css/home/home.css);
.slide-image{
    height: 300px;
}
.carousel__item {
  min-height: 200px;
  width: 100%;
  background-color: rgb(62, 199, 106);
  color: white;
  font-size: 20px;
  border-radius: 8px;
  display: flex;
  justify-content: center;
  align-items: center;
}

.carousel__slide {
  padding: 10px;
}

.carousel__prev,
.carousel__next {
  box-sizing: content-box;
  border: 5px solid white;
}
</style>