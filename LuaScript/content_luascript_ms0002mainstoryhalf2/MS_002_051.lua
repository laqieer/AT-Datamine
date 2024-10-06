-- このluaスクリプトは、MS_002_051.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_100011_06","100011_06_h")
Include("content_adv_advsmall_100011_06","Template100011_06_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos100011_06_006,"content_motion3d_advarea_common_adv_templatecontroller","Chr_523_01_ms0002_01_Controller","to Std_Loop",CameraAssetBundleName100011_06,CameraPos100011_06_006)
	Camera002 = SetPlayerTemplate("Actor002",nil,CharaPos100011_06_016,CameraAssetBundleName100011_06,CameraPos100011_06_016)
	Camera003 = SetTemplate("Actor003",nil,CharaPos100011_06_003,"content_motion3d_advarea_common_adv_templatecontroller","Chr_524_01_ms0002_01_Controller","to Std_Loop",CameraAssetBundleName100011_06,CameraPos100011_06_003)
	Camera004 = SetTemplate("Actor004",nil,CharaPos100011_06_005,"content_motion3d_advarea_common_adv_templatecontroller","Npc_1001_01_Controller","to Std_Loop",CameraAssetBundleName100011_06,CameraPos100011_06_005)
	Camera005 = SetTemplate("Actor005",nil,CharaPos100011_06_004,"content_motion3d_advarea_common_adv_templatecontroller","Chr_511_03_ms0002_01_Controller","to Std_Loop",CameraAssetBundleName100011_06,CameraPos100011_06_004)
	InitializeTemplateRandomCamera100011_06()
	InitializeTemplate100011_06()
-- ▼直接出力
heroId = GetPlayerStyleId()
if heroId == 101003001 or heroId == 101005001 or heroId == 101007001 then
    set_animationcontroller(Actor002,"Com_m_SitController", "to Sit01_Loop")
else
    set_animationcontroller(Actor002,"Com_f_SitController", "to Sit01_Loop")
end
-- ▲直接出力
-- ▼直接出力
CUT11 =  cat_template_camera("P11_Cam")
CUT12 =  cat_template_camera("P12_Cam")
CUT13 =  cat_template_camera("P13_Cam")
CUT14 =  cat_template_camera("P14_Cam")
CUT15 =  cat_template_camera("P15_Cam")
CUT16 =  cat_template_camera("P16_Cam", Actor002)
CUT17 =  cat_template_camera("P17_Cam")
CUT18 =  cat_template_camera("P18_Cam")
-- ▲直接出力
-- ▼直接出力
load_image("201010180", "content_still_20101018_image", "201010180_StillImage")
load_image("201010240", "content_still_20101024_image", "201010240_StillImage")
load_image("201010241", "content_still_20101024_image", "201010241_StillImage")
load_image("201010242", "content_still_20101024_image", "201010242_StillImage")
load_image("201010243", "content_still_20101024_image", "201010243_StillImage")
load_image("201010310", "content_still_20101031_image", "201010310_StillImage")
load_image("101010010", "content_still_10101001_image", "101010010_StillImage")
load_image("101010140", "content_still_10101014_image", "101010140_StillImage")
load_image("101010150", "content_still_10101015_image", "101010150_StillImage")
-- ▲直接出力
-- ▼直接出力
set_enable_auto_lookat_all(false)
set_pos(Actor005,{3.063 , 0.02 , 1.647})
Hide(Actor004)
-- ▲直接出力
-- ▼直接出力
DontChangeRandomCamera(false)
show_image("201010180", 0.0, 0.0, 0, true, false)
-- ▲直接出力
-- ▼直接出力
chair01 = get_object("geo_chair_08")
set_pos(chair01,{3.044 , 0 , 1.646})
set_rot(chair01,{0, 85.363 , 0})

chair02 = get_object("geo_chair_13")
set_pos(chair02,{4.269 , 0 ,0.126})
set_rot(chair02,{0, -48.581 , 0})

chair03 = get_object("geo_chair_14")
set_pos(chair03,{1.911 , 0 , -0.097})
set_rot(chair03,{0, -61.267 , 0})

chair04 = get_object("geo_chair_15")
set_pos(chair04,{0.253 , 0 , 0.636})
-- ▲直接出力
-- ▼直接出力
load_sound("BGM_ADV_Tyrfing_Piano")
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(100012)
	Actor001 = InitializeCharacter_3D("101070","001","101070001","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializePlayerCharacter("Actor002")
	Actor003 = InitializeCharacter_3D("101002","002","101002002","content_animationpack__common","FacialPack","Actor003")
	Actor004 = InitializeCharacter_3D("101059","001","101059001","content_animationpack__common","FacialPack","Actor004")
	Actor005 = InitializeCharacter_3D("101035","003","101035003","content_animationpack__common","FacialPack","Actor005")
	template1()
end

function Play()
	StartPlay()

-- ▼直接出力
wait_time(1)
-- ▲直接出力
-- ▼直接出力
CloseTalkWindow()
fadeout(0,0,0,1.0, CHARA_IN_IN)
wait_time(CHARA_IN_IN)
show_image("201010240", 0.0, 0.0, STILL_SWITCH_TIME ,true,true)
set_scale_image(0.7,0.7)
wait_time(0.7)
fadein(0.4)
-- ▲直接出力
-- ▼直接出力
wait_time(0.5)
-- ▲直接出力
-- ▼直接出力
PlayPartVoiceDirect("フライクーゲル","0049")
wait_time(0.6)
voice_play("VO_101070001_sp_0001_1")
-- ▲直接出力

	--★★フライクーゲル★★:
	Talk(Actor001,"CHRNAME_FREIKUGEL","simple","N","MS_002_0510006")


	--★★フライクーゲル★★:
	Talk(Actor001,"CHRNAME_FREIKUGEL","simple","N","MS_002_0510007")

	open_select_window_tag(Actor002,"Normal","MS_002_0510009","MS_002_0510010")
	if is_select(1) then
		goto Block1_1
	elseif is_select(2) then
		goto Block1_2
	end

::Block1_1::
	CloseTalkWindow()
-- ▼直接出力
CloseTalkWindow()
fadeout(0,0,0,0.2, 0.3)
wait_time(0.3)
show_image("201010241", 0.0, 0.0, STILL_SWITCH_TIME ,true,true) --0.6秒
set_position_image(0,50)
wait_time(0.5)
fadein(0.3)
wait_time(0.3)
-- ▲直接出力
-- ▼直接出力
PlayPartVoiceDirect("フライクーゲル","0061")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★フライクーゲル★★:森！！森！！森だよね！！<br>やっぱり森だよわかってるね！！
	Talk(Actor001,"CHRNAME_FREIKUGEL","simple","N","MS_002_0510013")

-- ▼直接出力
PlayPartVoiceDirect("リリアーナ","0002")
-- ▲直接出力
	change_face(Actor005,"Normal")

	--★★ロンギヌス★★:「夏に行くなら？」の質問って<br>普通「<dot>山</dot>か海か」では………
	Talk(Actor005,"CHRNAME_LONGINUS","simple","N","MS_002_0510014")

-- ▼直接出力
PlayPartVoiceDirect("フライクーゲル","0059")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★フライクーゲル★★:森がない山なんてある！？
	Talk(Actor001,"CHRNAME_FREIKUGEL","simple","N","MS_002_0510016")

	change_face(Actor001,"Normal")

	--★★フライクーゲル★★:ないよねえ！？
	Talk(Actor001,"CHRNAME_FREIKUGEL","simple","N","MS_002_0510017")

-- ▼直接出力
CloseTalkWindow()
fadeout(0,0,0,0.2, 0.15)
wait_time(0.15)
show_image("201010242", 0.0, 0.0, STILL_SWITCH_TIME ,true,true)
set_position_image(0,20)
fadein(0.3)
wait_time(0.3)
-- ▲直接出力
-- ▼直接出力
PlayPartVoiceDirect("リリアーナ","0034")
-- ▲直接出力
	change_face(Actor005,"Normal")

	--★★ロンギヌス★★:あるんじゃないでしょうか
	Talk(Actor005,"CHRNAME_LONGINUS","simple","N","MS_002_0510019")

	change_face(Actor001,"Normal")

	--★★フライクーゲル★★:それはともかく森は<ruby=グッスメル>不思議な香り</ruby>がするよね…<br>森のパワーを感じられる…
	Talk(Actor001,"CHRNAME_FREIKUGEL","simple","N","MS_002_0510020")

-- ▼直接出力
PlayPartVoiceDirect("フライクーゲル","0012")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★フライクーゲル★★:聞こえてくるよ！！聞こえてくるよ！！<br>森の動物たちの声！川のせせらぎ！ 
	Talk(Actor001,"CHRNAME_FREIKUGEL","simple","N","MS_002_0510022")

-- ▼直接出力
PlayPartVoiceDirect("リリアーナ","0009")
-- ▲直接出力
	change_face(Actor005,"Normal")

	--★★ロンギヌス★★:聞こえてきますね<br>あなたの声だけが
	Talk(Actor005,"CHRNAME_LONGINUS","simple","N","MS_002_0510023")

	goto Block1end

::Block1_2::
	CloseTalkWindow()
-- ▼直接出力
CloseTalkWindow()
fadeout(0,0,0,0.2, 0.3)
wait_time(0.3)
show_image("201010241", 0.0, 0.0, STILL_SWITCH_TIME ,true,true) --0.6秒
set_position_image(0,50)
wait_time(0.5)
fadein(0.3)
wait_time(0.3)
-- ▲直接出力
-- ▼直接出力
PlayPartVoiceDirect("フライクーゲル","0060")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★フライクーゲル★★:海はイイよね…
	Talk(Actor001,"CHRNAME_FREIKUGEL","simple","N","MS_002_0510026")

	change_face(Actor001,"Normal")

	--★★フライクーゲル★★:ほら、向こうに見える？<br>あれはなにかな？ホットな白い砂浜かな？
	Talk(Actor001,"CHRNAME_FREIKUGEL","simple","N","MS_002_0510027")

-- ▼直接出力
PlayPartVoiceDirect("レーヴァテイン","0034")
-- ▲直接出力
	change_face(Actor003,"Normal")

	--★★レーヴァテイン★★:黒板かな
	Talk(Actor003,"CHRNAME_LAEVATEIN","simple","N","MS_002_0510028")

-- ▼直接出力
voice_play("VO_101070001_sp_0002_1")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★フライクーゲル★★:ベェリィ・キュートな水着をね、買うんだ…！ <br>レーヴァにもチョイスしてあげるからね！
	Talk(Actor001,"CHRNAME_FREIKUGEL","simple","N","MS_002_0510029")

-- ▼直接出力
CloseTalkWindow()
fadeout(0,0,0,0.2, 0.3)
wait_time(0.3)
show_image("201010243", 0.0, 0.0, STILL_SWITCH_TIME ,true,true) --0.6秒
set_scale_image(0.8,0.8)
fadein(0.3)
wait_time(0.3)
-- ▲直接出力
-- ▼直接出力
PlayPartVoiceDirect("レーヴァテイン","0058")
-- ▲直接出力
	change_face(Actor003,"Normal")

	--★★レーヴァテイン★★:…そ、それはありがと<br>でも泳ぐのだるそう…
	Talk(Actor003,"CHRNAME_LAEVATEIN","simple","N","MS_002_0510030")

	change_face(Actor001,"Normal")

	--★★フライクーゲル★★:野菜に肉に魚も焼いて！<br>焦げた焼きそば買ってきて！
	Talk(Actor001,"CHRNAME_FREIKUGEL","simple","N","MS_002_0510031")

-- ▼直接出力
PlayPartVoiceDirect("フライクーゲル","0012")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★フライクーゲル★★:太陽が傾きかけたころに食べるのさ！<br>夜の潮風が気持ちいい！味は文句なし！
	Talk(Actor001,"CHRNAME_FREIKUGEL","simple","N","MS_002_0510032")

-- ▼直接出力
PlayPartVoiceDirect("レーヴァテイン","0053")
-- ▲直接出力
	change_face(Actor003,"Normal")

	--★★レーヴァテイン★★:………それはいいかも
	Talk(Actor003,"CHRNAME_LAEVATEIN","simple","N","MS_002_0510033")

	goto Block1end

::Block1end::
-- ▼直接出力
CloseTalkWindow()
fadeout(0,0,0,1.0, CHARA_IN_IN)
wait_time(CHARA_IN_IN)
hide_image(0)
PlayActionDirect(Actor001,"to MS002_051_Sit01_Loop")
PlayActionDirect(Actor003,"to MS002_051_Sit05_Loop")
PlayActionDirect(Actor005,"to MS002_051_Sit01LookRight_Loop")
setup_small_camera_start(CUT11)
off_cameraframe()
off_screencolor()
--フェードイン
wait_time(0.3 + 0.2)
fadein(CHARA_IN_OUT)
wait_time(CHARA_IN_OUT + 0.5)
-- ▲直接出力
-- ▼直接出力
PlayPartVoiceDirect("フライクーゲル","0066")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★フライクーゲル★★:…わたし、テンション間違ってる？
	Talk(Actor001,"CHRNAME_FREIKUGEL","speech","L","MS_002_0510035")

-- ▼直接出力
PlayPartVoiceDirect("レーヴァテイン","0010")
-- ▲直接出力
	change_face(Actor003,"Smile")

	--★★レーヴァテイン★★:
	Talk(Actor003,"CHRNAME_LAEVATEIN","speech","L","MS_002_0510036")

-- ▼直接出力
PlayPartVoiceDirect("リリアーナ","0010")
-- ▲直接出力
	change_face(Actor005,"Smile")

	--★★ロンギヌス★★:学生はお金がありませんからおしゃべりが最上の娯楽ですよ
	Talk(Actor005,"CHRNAME_LONGINUS","speech","L","MS_002_0510037")

-- ▼直接出力
PlayPartVoiceDirect("フライクーゲル","0057")
-- ▲直接出力
	change_face(Actor001,"Laugh")

	--★★フライクーゲル★★:お泊り会なんてはじめてしかも学園になんて
	Talk(Actor001,"CHRNAME_FREIKUGEL","speech","L","MS_002_0510038")

-- ▼直接出力
PlayPartVoiceDirect("レーヴァテイン","0007")
-- ▲直接出力
	change_face(Actor003,"Normal")

	--★★レーヴァテイン★★:だからだよ
	Talk(Actor003,"CHRNAME_LAEVATEIN","speech","L","MS_002_0510039")

-- ▼直接出力
PlayPartVoiceDirect("フライクーゲル","0028")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★フライクーゲル★★:え？
	Talk(Actor001,"CHRNAME_FREIKUGEL","speech","L","MS_002_0510040")

-- ▼直接出力
CloseTalkWindow()
setup_small_camera_start(CUT12)
-- ▲直接出力

	--★★レーヴァテイン★★:はじめてのことを たくさん思い出にしていかないと
	Talk(Actor003,"CHRNAME_LAEVATEIN","speech","L","MS_002_0510041")

-- ▼直接出力
PlayActionDirect(Actor001,"to MS002_051_Sit01LookCenter_Loop")
-- ▲直接出力

	--★★レーヴァテイン★★:思い出を奪われてばっかりじゃ<br>シャクだし
	Talk(Actor003,"CHRNAME_LAEVATEIN","speech","L","MS_002_0510042")


	--★★レーヴァテイン★★:逃げ場がなくなるのも<br>つらいでしょ
	Talk(Actor003,"CHRNAME_LAEVATEIN","speech","L","MS_002_0510043")

	change_face(Actor001,"Normal")

	--★★フライクーゲル★★:…だね
	Talk(Actor001,"CHRNAME_FREIKUGEL","speech","L","MS_002_0510044")

-- ▼直接出力
PlayPartVoiceDirect("リリアーナ","0002")
-- ▲直接出力
	change_face(Actor005,"Normal")

	--★★ロンギヌス★★:Player Nameさんと逃げてそのあと…どうする気だったんです？
	Talk(Actor005,"CHRNAME_LONGINUS","speech","L","MS_002_0510045")

-- ▼直接出力
CloseTalkWindow()
setup_small_camera_start(CUT13)
-- ▲直接出力
-- ▼直接出力
PlayPartVoiceDirect("フライクーゲル","0058")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★フライクーゲル★★:ああっ、それは…ご、ゴメンでも…どうするって？
	Talk(Actor001,"CHRNAME_FREIKUGEL","speech","L","MS_002_0510046")

-- ▼直接出力
PlayPartVoiceDirect("レーヴァテイン","0057")
-- ▲直接出力

	--★★レーヴァテイン★★:…Player Nameとふたりきりで逃避行して、住む場所とか
	Talk(Actor003,"CHRNAME_LAEVATEIN","speech","L","MS_002_0510047")

	change_face(Actor001,"Shy")

	--★★フライクーゲル★★:あっ、あー、え～、んん～…？
	Talk(Actor001,"CHRNAME_FREIKUGEL","speech","L","MS_002_0510048")

-- ▼直接出力
PlayPartVoiceDirect("リリアーナ","0046")
-- ▲直接出力

	--★★ロンギヌス★★:ノープランなんですね…
	Talk(Actor005,"CHRNAME_LONGINUS","speech","L","MS_002_0510049")

-- ▼直接出力
PlayPartVoiceDirect("レーヴァテイン","0045")
-- ▲直接出力

	--★★レーヴァテイン★★:………それだけ<%player>のこと<br>ばかり考えてたってことね
	Talk(Actor003,"CHRNAME_LAEVATEIN","speech","L","MS_002_0510050")

-- ▼直接出力
PlayPartVoiceDirect("フライクーゲル","0034")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★フライクーゲル★★:…恥ずかしいこと、言わないでよ
	Talk(Actor001,"CHRNAME_FREIKUGEL","speech","L","MS_002_0510051")

-- ▼直接出力
PlayPartVoiceDirect("リリアーナ","0002")
-- ▲直接出力

	--★★ロンギヌス★★:ということで本題なのですが
	Talk(Actor005,"CHRNAME_LONGINUS","speech","L","MS_002_0510052")

-- ▼直接出力
CloseTalkWindow()
setup_small_camera_start(CUT11)
wait_time(1)
-- ▲直接出力
-- ▼直接出力
PlayPartVoiceDirect("フライクーゲル","0029")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★フライクーゲル★★:えーっ！？お泊り会が本題じゃないの！？
	Talk(Actor001,"CHRNAME_FREIKUGEL","speech","L","MS_002_0510053")


	--★★ロンギヌス★★:それは建前です
	Talk(Actor005,"CHRNAME_LONGINUS","speech","L","MS_002_0510054")


	--★★フライクーゲル★★:聞いてないんだけど！！
	Talk(Actor001,"CHRNAME_FREIKUGEL","speech","L","MS_002_0511001")

-- ▼直接出力
PlayPartVoiceDirect("レーヴァテイン","0053")
-- ▲直接出力

	--★★レーヴァテイン★★:言ってないからね
	Talk(Actor003,"CHRNAME_LAEVATEIN","speech","L","MS_002_0510055")

-- ▼直接出力
CloseTalkWindow()
setup_small_camera_start(CUT14)
wait_time(0.4)
-- ▲直接出力
-- ▼直接出力
PlayPartVoiceDirect("リリアーナ","0007")
-- ▲直接出力
	change_face(Actor005,"Anger")

	--★★ロンギヌス★★:イミテーション・ディナタンは 他二体のイミテーションを治癒次第攻めて来ます
	Talk(Actor005,"CHRNAME_LONGINUS","speech","L","MS_002_0510056")

-- ▼直接出力
PlayPartVoiceDirect("レーヴァテイン","0049")
-- ▲直接出力

	--★★レーヴァテイン★★:ここで迎え撃たなきゃならない
	Talk(Actor003,"CHRNAME_LAEVATEIN","speech","L","MS_002_0510057")

-- ▼直接出力
PlayPartVoiceDirect("フライクーゲル","0028")
-- ▲直接出力

	--★★フライクーゲル★★:あれっ、じゃあこのお泊り会自体──
	Talk(Actor001,"CHRNAME_FREIKUGEL","speech","L","MS_002_0510058")

-- ▼直接出力
setup_small_camera_start(CUT12)
-- ▲直接出力
-- ▼直接出力
PlayPartVoiceDirect("レーヴァテイン","0007")
-- ▲直接出力

	--★★レーヴァテイン★★:夜間の襲撃への備え
	Talk(Actor003,"CHRNAME_LAEVATEIN","speech","L","MS_002_0510059")

	change_face(Actor001,"Anger")

	--★★フライクーゲル★★:………だ、だましたなあ～…！
	Talk(Actor001,"CHRNAME_FREIKUGEL","speech","L","MS_002_0510060")

-- ▼直接出力
PlayPartVoiceDirect("レーヴァテイン","0051")
-- ▲直接出力

	--★★レーヴァテイン★★:閑話休題
	Talk(Actor003,"CHRNAME_LAEVATEIN","speech","L","MS_002_0510061")

	change_face(Actor001,"Surprise")

	--★★フライクーゲル★★:閑話しようよ～っ！！
	Talk(Actor001,"CHRNAME_FREIKUGEL","speech","L","MS_002_0510062")

-- ▼直接出力
CloseTalkWindow()
setup_small_camera_start(CUT15)
wait_time(0.7)
bgm_play("Stop_BGM_Bus_MidFade")
-- ▲直接出力
	change_face(Actor005,"Normal")

	--★★ロンギヌス★★:…Player Nameさんにもう一度ログレスに潜ってもらいたいんです
	Talk(Actor005,"CHRNAME_LONGINUS","speech","L","MS_002_0510063")

-- ▼直接出力
PlayPartVoiceDirect("フライクーゲル","0028")
-- ▲直接出力

	--★★フライクーゲル★★:………ええっ
	Talk(Actor001,"CHRNAME_FREIKUGEL","speech","L","MS_002_0510064")

-- ▼直接出力
bgm_play("BGM_ADV_Tyrfing_Piano")
-- ▲直接出力
	change_face(Actor005,"Anger")

	--★★ロンギヌス★★:………ティルフィングを、呼び戻すために
	Talk(Actor005,"CHRNAME_LONGINUS","speech","L","MS_002_0510065")

	change_face(Actor001,"Sad")

	--★★フライクーゲル★★:
	Talk(Actor001,"CHRNAME_FREIKUGEL","speech","L","MS_002_0510067")

	open_select_window_tag(Actor002,"Normal","MS_002_0510069")
	if is_select(1) then
		goto Block2_1
	end

::Block2_1::
	CloseTalkWindow()
-- ▼直接出力
CloseTalkWindow()
fadeout(0,0,0,0.2, 0.4)
wait_time(0.4)
on_cameraframe(2)
on_screencolor(IMAGE_COLOR, 0, -50)
show_image("201010310", 0.0, 0.0, STILL_SWITCH_TIME ,true,true) --0.6秒
set_scale_image(0.9,0.9)
wait_time(0.3 + 0.2)--0.6秒+0.5秒
fadein(0.3)
wait_time(0.3)
-- ▲直接出力
	goto Block2end

::Block2end::
-- ▼直接出力
PlayPartVoiceDirect("リリアーナ","0007")
-- ▲直接出力
	change_face(Actor005,"Normal")

	--★★ロンギヌス★★:私たち継守会メンバーは皆──
	Talk(Actor005,"CHRNAME_LONGINUS","simple","N","MS_002_0510074")


	--★★ロンギヌス★★:<ruby=あなた>最後の継承者</ruby>を過去に導くべく<br>現代で目覚めた存在です
	Talk(Actor005,"CHRNAME_LONGINUS","simple","N","MS_002_0510075")


	--★★ロンギヌス★★:皆、過去の継承者の<br><ruby=ファースト・キラーズ>最初の武器</ruby>となった者たちなのです
	Talk(Actor005,"CHRNAME_LONGINUS","simple","N","MS_002_0510077")

-- ▼直接出力
CloseTalkWindow()
fadeout(0,0,0,0.2, 0.4)
wait_time(0.4)
show_image("101010010", 0.0, 0.0, 0, true, false)
set_scale_image(0.9,0.9)
--フェードイン
wait_time(0.3 + 0.2)--0.6秒+0.5秒
fadein(0.3)
wait_time(0.3)
-- ▲直接出力
-- ▼直接出力
PlayPartVoiceDirect("レーヴァテイン","0049")
-- ▲直接出力

	--★★レーヴァテイン★★:…ティルフィングはログレスの歴史へと潜ったあなたの後を追って、ね
	Talk(Actor003,"CHRNAME_LAEVATEIN","simple","N","MS_002_0510080")


	--★★ロンギヌス★★:<ruby=ノワール>過去の継承者</ruby>の導き手となるべく<br><ruby=カリバーン>自身の聖遺物</ruby>へ潜行したのです
	Talk(Actor005,"CHRNAME_LONGINUS","simple","N","MS_002_0510081")

-- ▼直接出力
PlayPartVoiceDirect("リリアーナ","0025")
-- ▲直接出力

	--★★ロンギヌス★★:本来、<ruby=あなた>最後の継承者</ruby>が現代へ帰還するとともに<br>彼女も戻ってくるはずだったのですが…
	Talk(Actor005,"CHRNAME_LONGINUS","simple","N","MS_002_0510084")

	change_face(Actor001,"Normal")

	--★★フライクーゲル★★:…なんらかの原因で<br>帰ってきていない…？
	Talk(Actor001,"CHRNAME_FREIKUGEL","simple","N","MS_002_0510086")

-- ▼直接出力
PlayPartVoiceDirect("アルハン","0034")
-- ▲直接出力

	--★★アルハン★★:未練があるのかもしれぬ
	Talk(Actor004,"NPCNAME_0313","simple","N","MS_002_0510088")

-- ▼直接出力
CloseTalkWindow()
fadeout(0,0,0,1.0, CHARA_IN_IN)
wait_time(CHARA_IN_IN)
hide_image(0)
Appear(Actor004)
PlayActionDirect(Actor001,"to MS002_051_Sit01_Loop")
PlayActionDirect(Actor003,"to MS002_051_Sit05LookLeft_Loop")
PlayActionDirect(Actor005,"to MS002_051_Sit01LookLeft_Loop")
PlayActionDirect(Actor004,"to Std_start_pose")
setup_small_camera_start(CUT15)
off_cameraframe()
off_screencolor()
--フェードイン
wait_time(0.3 + 0.2)
fadein(CHARA_IN_OUT)
wait_time(CHARA_IN_OUT + 0.5)
-- ▲直接出力
-- ▼直接出力
PlayActionDirect(Actor004,"to Std_start")
wait_time(2.5)
-- ▲直接出力
-- ▼直接出力
PlayPartVoiceDirect("アルハン","0002")
-- ▲直接出力
	change_face(Actor004,"Anger")

	--★★アルハン★★:お泊り会に混ざりに来たわけではないぞ念のため言っておくが
	Talk(Actor004,"NPCNAME_0313","speech","L","MS_002_0510091")

-- ▼直接出力
PlayPartVoiceDirect("レーヴァテイン","0049")
-- ▲直接出力

	--★★レーヴァテイン★★:そんなことわかってるよそれより――
	Talk(Actor003,"CHRNAME_LAEVATEIN","speech","L","MS_002_0510092")

-- ▼直接出力
PlayPartVoiceDirect("フライクーゲル","0023")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★フライクーゲル★★:…未練って<br>ティルフィングに限ってそんな──
	Talk(Actor001,"CHRNAME_FREIKUGEL","speech","L","MS_002_0510093")

-- ▼直接出力
CloseTalkWindow()
setup_small_camera_start(CUT17)
-- ▲直接出力
-- ▼直接出力
PlayPartVoiceDirect("アルハン","0034")
-- ▲直接出力
	change_face(Actor004,"Normal")

	--★★アルハン★★:ティルフィングがいくら帰って来たいと願っても<br>彼女自身の意志ではどうすることもできぬ
	Talk(Actor004,"NPCNAME_0313","speech","L","MS_002_0510094")


	--★★アルハン★★:潜在的な思い残しが彼女を囚え…現代への帰還を妨げている可能性がある
	Talk(Actor004,"NPCNAME_0313","speech","L","MS_002_0510095")


	--★★アルハン★★:それは些細な出来事かもしれぬが<br><%player>でなければ探り当てられぬ
	Talk(Actor004,"NPCNAME_0313","speech","L","MS_002_0510096")

	change_face(Actor004,"Sad")

	--★★アルハン★★:…継承者の力があれば<br>運命を変えられたかもしれない出来事…
	Talk(Actor004,"NPCNAME_0313","speech","L","MS_002_0510097")

-- ▼直接出力
PlayPartVoiceDirect("アルハン","0009")
-- ▲直接出力
	change_face(Actor004,"Anger")

	--★★アルハン★★:そこへ…短時間の潜行をしてもらいたい
	Talk(Actor004,"NPCNAME_0313","speech","L","MS_002_0510098")

-- ▼直接出力
PlayPartVoiceDirect("フライクーゲル","0028")
-- ▲直接出力

	--★★フライクーゲル★★:ま、待ってよ！
	Talk(Actor001,"CHRNAME_FREIKUGEL","speech","L","MS_002_0510100")

-- ▼直接出力
setup_small_camera_start(CUT18)
PlayActionDirect(Actor001,"to MS002_051_Sit01_End")
-- ▲直接出力

	--★★フライクーゲル★★:ダーリンはその潜行の消耗で<br>記憶を失くしたんだよ…？
	Talk(Actor001,"CHRNAME_FREIKUGEL","speech","L","MS_002_0510101")

-- ▼直接出力
PlayPartVoiceDirect("フライクーゲル","0057")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★フライクーゲル★★:ぐずぐず言ってる場合じゃないかもだけどや、休ませてあげないと──
	Talk(Actor001,"CHRNAME_FREIKUGEL","speech","L","MS_002_0510102")


	--★★フライクーゲル★★:消耗した状態で潜行して<br>例えばもし、過去の歴史内で死んじゃったら…
	Talk(Actor001,"CHRNAME_FREIKUGEL","speech","L","MS_002_0510103")

	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
PlayPartVoiceDirect("フライクーゲル","0024")
-- ▲直接出力
	change_face(Actor001,"Anger")

	--★★フライクーゲル★★:もう、帰って来られないんだよ…？？
	Talk(Actor001,"CHRNAME_FREIKUGEL","speech","L","MS_002_0510104")

-- ▼直接出力
PlayPartVoiceDirect("アルハン","0007")
-- ▲直接出力
	change_face(Actor004,"Sad")

	--★★アルハン★★:細心の注意を払うそれでも負担は免れぬが…
	Talk(Actor004,"NPCNAME_0313","speech","L","MS_002_0510105")

-- ▼直接出力
setup_small_camera_start(CUT16)
setup_small_offset_camera_start(Actor002)
PlayActionDirect(Actor003,"to MS002_051_Sit05_Loop")
PlayActionDirect(Actor005,"to MS002_051_Sit01LookRight_Loop")
set_animationcontroller(Actor001, "Chr_523_01_StdController", "to Std_Loop")
-- ▲直接出力
-- ▼直接出力
PlayPartVoiceDirect("フライクーゲル","0049")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★フライクーゲル★★:他の方法はないの？<br>わたし、なんだってするよ…！？
	Talk(Actor001,"CHRNAME_FREIKUGEL","speech","L","MS_002_0510106")

-- ▼直接出力
PlayPartVoiceDirect("アルハン","0040")
-- ▲直接出力

	--★★アルハン★★:………<%player>にしか<br>できぬことだ
	Talk(Actor004,"NPCNAME_0313","speech","L","MS_002_0510107")

	open_select_window_tag(Actor002,"Normal","MS_002_0510109")
	if is_select(1) then
		goto Block3_1
	end

::Block3_1::
	CloseTalkWindow()
-- ▼直接出力
setup_small_camera_start(CUT11)
-- ▲直接出力
	goto Block3end

::Block3end::

	--★★フライクーゲル★★:
	Talk(Actor001,"CHRNAME_FREIKUGEL","speech","L","MS_002_0510113")

-- ▼直接出力
PlayPartVoiceDirect("フライクーゲル","0023")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★フライクーゲル★★:
	Talk(Actor001,"CHRNAME_FREIKUGEL","speech","L","MS_002_0510114")

-- ▼直接出力
PlayActionDirect(Actor001,"to  Std_No")
SkipDefaultMotion(Actor001)
-- ▲直接出力

	--★★フライクーゲル★★:そー言うしか、ない…じゃん
	Talk(Actor001,"CHRNAME_FREIKUGEL","speech","L","MS_002_0510116")

-- ▼直接出力
PlayPartVoiceDirect("アルハン","0035")
-- ▲直接出力
	change_face(Actor004,"Anger")

	--★★アルハン★★:一刻の猶予もないすぐにでも──
	Talk(Actor004,"NPCNAME_0313","speech","L","MS_002_0510117")

-- ▼直接出力
CloseTalkWindow()
bgm_play("Stop_BGM_Bus_2")
shake_camera(CUT11, 0.42, 3)
se_play("SE_ADV_MA_01A111_14_Earthquake")
set_enable_auto_lookat(Actor001, true)
wait_time(0.2)
PlayActionDirect(Actor001,"to  Std_Surp")
wait_time(1)
-- ▲直接出力
-- ▼直接出力
CloseTalkWindow()
fadeout(255,255,255,1.0, FADE_TIME)--ホワイトアウト
show_image("101010150", 0.0, 0.0, 0, true, false)
set_scale_image(20,20)
--wait_time(TIME_ELAPSED)
fadein(FADE_TIME)
wait_time(FADE_TIME + 0.3)
-- ▲直接出力
-- ▼直接出力
PlayPartVoiceDirect("アルハン","0028")
-- ▲直接出力
	change_face(Actor004,"Surprise")

	--★★アルハン★★:！？なんだ…！？
	Talk(Actor004,"NPCNAME_0313","speech","L","MS_002_0510120")

-- ▼直接出力
PlayPartVoiceDirect("リリアーナ","0030")
-- ▲直接出力
	change_face(Actor005,"Surprise")

	--★★ロンギヌス★★:この揺れ、まさか…もう──
	Talk(Actor005,"CHRNAME_LONGINUS","speech","L","MS_002_0510121")

-- ▼直接出力
PlayPartVoiceDirect("レーヴァテイン","0007")
-- ▲直接出力
	change_face(Actor003,"Anger")

	--★★レーヴァテイン★★:………来たね
	Talk(Actor003,"CHRNAME_LAEVATEIN","speech","L","MS_002_0510122")

-- ▼直接出力
se_play("SE_LoopSE_Stop")
-- ▲直接出力
	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
heroId = GetPlayerStyleId()
if heroId == 101003001 or heroId == 101005001 or heroId == 101007001 then
else
end
load_image_preload("201010180", "content_still_20101018_image", "201010180_StillImage")
load_image_preload("201010240", "content_still_20101024_image", "201010240_StillImage")
load_image_preload("201010241", "content_still_20101024_image", "201010241_StillImage")
load_image_preload("201010242", "content_still_20101024_image", "201010242_StillImage")
load_image_preload("201010243", "content_still_20101024_image", "201010243_StillImage")
load_image_preload("201010310", "content_still_20101031_image", "201010310_StillImage")
load_image_preload("101010010", "content_still_10101001_image", "101010010_StillImage")
load_image_preload("101010140", "content_still_10101014_image", "101010140_StillImage")
load_image_preload("101010150", "content_still_10101015_image", "101010150_StillImage")
preload_sound("BGM_ADV_Tyrfing_Piano")
	InitializeLoad_Preload()
	load_area_scene_preload(100012)
	InitializeCharacter_3D_Preload("101070","001","101070001","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101002","002","101002002","content_animationpack__common","FacialPack","Actor003")
	InitializeCharacter_3D_Preload("101059","001","101059001","content_animationpack__common","FacialPack","Actor004")
	InitializeCharacter_3D_Preload("101035","003","101035003","content_animationpack__common","FacialPack","Actor005")
	system.PreLoadRequest(CameraAssetBundleName100011_06)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
