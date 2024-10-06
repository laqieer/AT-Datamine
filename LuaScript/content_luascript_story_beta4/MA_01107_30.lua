-- このluaスクリプトは、MA_01107_30.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110021_01","110021_01_h")
Include("content_adv_advsmall_110021_01","Template110021_01_h")
-- ▼直接出力
MobsNo = 0
-- ▲直接出力
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos110021_01_005,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName110021_01,CameraPos110021_01_005)
	Camera002 = SetTemplate("Actor002",nil,CharaPos110021_01_001,"content_motion3d_advarea_common_adv_templatecontroller","Chr_001_01_StdController","to Std_Loop",CameraAssetBundleName110021_01,CameraPos110021_01_001)
	Camera003 = SetTemplate("Actor003",nil,CharaPos110021_01_009,"content_motion3d_advarea_common_adv_templatecontroller","Chr_004_01_StdController","to Std_Loop",CameraAssetBundleName110021_01,CameraPos110021_01_009)
	Camera004 = SetTemplate("Actor004",-55,CharaPos110021_01_006,"content_motion3d_advarea_common_adv_templatecontroller","Chr_502_01_StdController","to Std_Loop",CameraAssetBundleName110021_01,CameraPos110021_01_006)
	Camera005 = SetTemplate("Actor005",nil,CharaPos110021_01_007,"content_motion3d_advarea_common_adv_templatecontroller","Chr_501_01_StdController","to Std_Loop",CameraAssetBundleName110021_01,CameraPos110021_01_007)
	InitializeTemplateRandomCamera110021_01()
	InitializeTemplate110021_01()
-- ▼直接出力
load_image("101010140", "content_still_10101014_image", "101010140_StillImage")
load_image("10101023", "content_still_10101023_image", "101010230_StillImage")
set_enable_auto_lookat_all(false)
keep_ik_lookat(Actor001,Actor002,"J_Head")
keep_ik_lookat(Actor002,Actor001,"J_Head")
keep_ik_lookat(Actor004,Actor001,"J_Head")
keep_ik_lookat(Actor005,Actor001,"J_Head")
Hide(Actor004)
Hide(Actor005)
turn_lookat(Actor001,Actor002,1)
turn_lookat(Actor002,Actor001,1)
lookat_weight(Actor001,0.6, 0.03, 0.7, 0)
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(115030)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101010","001","101010001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("101014","001","101014001","content_animationpack__common","FacialPack","Actor003")
	Actor004 = InitializeCharacter_3D("101011","001","101011001","content_animationpack__common","FacialPack","Actor004")
	Actor005 = InitializeCharacter_3D("101012","001","101012001","content_animationpack__common","FacialPack","Actor005")
	Actor006 = InitializeCharacter_TextOnly()
	Actor007 = InitializeCharacter_2DOnly("101011","001","101011001")
	template1()
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor004,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor005,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

	PlayAction(Actor001,"to  Std_Surp")
	change_face(Actor001,"Surprise")

	--★★ノワール★★:ランスロット！？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01107_300002")


	--★★ランスロット★★:すぐに戻る
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","MA_01107_300003")


	--★★ノワール★★:どこへ！？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01107_300004")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力

	--★★ランスロット★★:ひとりで平気だ
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","MA_01107_300005")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	open_select_window_tag(Actor001,"Normal","MA_01107_300007","MA_01107_300008")
	if is_select(1) then
		goto Block1_1
	elseif is_select(2) then
		goto Block1_2
	end

::Block1_1::
	CloseTalkWindow()
	play_head_motion(Actor001, "No", 0.3, 1.0, false)
	change_face(Actor001,"Sad")

	--★★ノワール★★:平気なように見えないんだよ、ランスロット
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01107_300010")

	PlayAction(Actor002,"to  Std_Talk")
	change_face(Actor002,"Smile")

	--★★ランスロット★★:いつもどおりだ<br>フットワークも軽くて、元気だろう？
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","MA_01107_300011")

	change_face(Actor001,"Sad")

	--★★ノワール★★:父さんのときも<br>そうやって飛び出して行った
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01107_300012")

	goto Block1end

::Block1_2::
	CloseTalkWindow()
	change_face(Actor001,"Normal")

	--★★ノワール★★:『最強騎士』のお前が<br>そう簡単に後れを取るとは思わない
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01107_300014")

	play_head_motion(Actor001, "No", 0.3, 1.0, false)
	change_face(Actor001,"Sad")

	--★★ノワール★★:だけど勝手じゃないか<br>いつもひとりで
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01107_300015")

	change_face(Actor001,"Sad")

	--★★ノワール★★:ずっとなにも言ってくれないで
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01107_300016")

	goto Block1end

::Block1end::
-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Talk")
	change_face(Actor001,"Sad")

	--★★ノワール★★:だから止めてるんじゃないか<br>またもし戻って来なかったら、と思うから
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01107_300018")

	change_face(Actor002,"Normal")

	--★★ランスロット★★:…
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","MA_01107_300019")


	--★★ノワール★★:…教えてくれよ<br>いつになったらあんたに並べる？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01107_300020")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Sad02")

	--★★ノワール★★:トリスタンに言われた<br>俺のすべては紛い物なんじゃないかって
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01107_300021")

-- ▼直接出力
setup_small_camera_start(RndCamera005)
-- ▲直接出力

	--★★トリスタン★★:…
	Talk(Actor003,"CHRNAME_TRISTAN","mind","L","MA_01107_300023")

-- ▼直接出力
setup_small_camera_start(RndCamera009)
-- ▲直接出力

	--★★ノワール★★:だからあんたは俺を信じられず<br>『本当』のことを言ってくれないんじゃないかと
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01107_300024")

	change_face(Actor002,"Sad")

	--★★ランスロット★★:…
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","MA_01107_300025")

-- ▼直接出力
setup_small_camera_start(Camera001)
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:けど…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01107_300026")


	--★★ギネヴィア2D★★:公衆の面前で物々しいわね
	Talk(Actor007,"CHRNAME_GUINEVERE","speech","L","MA_01107_300028")

-- ▼直接出力
CloseTalkWindow()
keep_delay_ik_lookat(Actor001,Actor004,"J_Head",1)
keep_delay_ik_lookat(Actor002,Actor004,"J_Head",1)
EntryWalk_2P(Actor004,Camera004,EntryData110021_01_06,CameraAssetBundleName110021_01,CameraPos110021_01_106,Actor005,CharaPos110021_01_007,CharaPos110021_01_107)
-- ▲直接出力
	play_head_motion(Actor004, "No", 0.3, 1.0, false)

	--★★ギネヴィア★★:ホント、信じらんない
	Talk(Actor004,"CHRNAME_GUINEVERE","speech","L","MA_01107_300030")

	change_face(Actor001,"Surprise")

	--★★ノワール★★:ギネヴィア
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01107_300031")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor004,"to  Std_Talk")

	--★★ギネヴィア★★:信じらんないくらい<br>わたし、助けてもらった
	Talk(Actor004,"CHRNAME_GUINEVERE","speech","L","MA_01107_300032")

	change_face(Actor004,"Laugh")

	--★★ギネヴィア★★:それは『本当』だと思うけど
	Talk(Actor004,"CHRNAME_GUINEVERE","speech","L","MA_01107_300033")

	PlayAction(Actor005,"to  Std_No")
-- ▼直接出力
set_enable_auto_lookat_all(true)
set_enable_auto_lookat(Actor004,false)
-- ▲直接出力
	change_face(Actor005,"Sad")

	--★★ディナタン★★:ごめんなさい、兄さん<br>立ち聞きしちゃった
	Talk(Actor005,"CHRNAME_DINATAN","speech","L","MA_01107_300034")

-- ▼直接出力
set_enable_auto_lookat_all(false)
-- ▲直接出力

	--★★ノワール★★:ディナタン
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01107_300035")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	change_face(Actor005,"Normal")

	--★★ディナタン★★:母さんの真似をしてリボンを編んでくれた<br>父さんの真似をして剣を握り続けた
	Talk(Actor005,"CHRNAME_DINATAN","speech","L","MA_01107_300036")

	play_head_motion(Actor005, "Nod", 0.3, 1.0, false)

	--★★ディナタン★★:ランス兄ちゃんを追って<br>ここに居ることを決めたんだよ
	Talk(Actor005,"CHRNAME_DINATAN","speech","L","MA_01107_300037")


	--★★ディナタン★★:それはぜんぶ<br>兄さんの『本当』だと思う
	Talk(Actor005,"CHRNAME_DINATAN","speech","L","MA_01107_300038")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★ランスロット★★:…
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","MA_01107_300039")

-- ▼直接出力
keep_delay_ik_lookat(Actor001,Actor002,"J_Head",0.5)
PlayActionDirect(Actor001,"to  Std_Talk")
turn_chara(Actor001,-140,0.5)
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:『本当』にできることを重ねて<br>あんたを追いかけて来た
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01107_300040")

-- ▼直接出力
setup_small_camera_start(Camera003)
-- ▲直接出力

	--★★トリスタン★★:…御苦労なことだね。本当に
	Talk(Actor003,"CHRNAME_TRISTAN","mind","L","MA_01107_300042")

-- ▼直接出力
setup_small_camera_start(Camera001)
set_rot(Actor002,{0,45,0})
-- ▲直接出力

	--★★ノワール★★:いつか向き合って話せるよな、ランスロット
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01107_300043")

-- ▼直接出力
setup_small_camera_start(Camera002)
-- ▲直接出力

	--★★ランスロット★★:…ノワール…
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","MA_01107_300044")

-- ▼直接出力
CloseTalkWindow()
show_image("101010140", 0.0, 0.0,0.3,false,false)
set_scale_image(20,20)
wait_time(0.3+ BLACK_WHITE_WAIT_TIME)
-- ▲直接出力
-- ▼直接出力
Camera003=setup_small_camera_resetting(Actor003,CharaPos003,CameraPos003)
setup_small_camera_start()
-- ▲直接出力
	change_face(Actor003,"Smile")

	--★★トリスタン★★:ふふ、アツくなっちゃったんだろうけど<br>そろそろ出撃してくれないかな？
	Talk(Actor003,"CHRNAME_TRISTAN","simple","N","MA_01107_300046")

-- ▼直接出力
set_enable_auto_lookat_all(false)
CloseTalkWindow()
hide_image(0.3)
-- ▲直接出力
-- ▼直接出力
set_common_look_at(Actor001,Actor003)
set_common_look_at(Actor002,Actor003)
set_common_look_at(Actor004,Actor003)
set_common_look_at(Actor005,Actor003)
-- ▲直接出力
	open_cutin(2,1)
	on_cutin(1,Actor001,"Surprise")
	on_cutin(2,Actor002,"Surprise")

	--★★ノワール／ランスロット★★:あっ
	Talk(Actor006,"CHRNAME_NOIR_LANCELOT","speech","N","MA_01107_300047")

	close_cutin()
	PlayAction(Actor003,"to  Std_Talk")
	change_face(Actor003,"Normal")

	--★★トリスタン★★:ボクらはルーシャス様のお相手で忙しい
	Talk(Actor003,"CHRNAME_TRISTAN","speech","L","MA_01107_300048")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力

	--★★トリスタン★★:キミらは並んで出て行きなよ
	Talk(Actor003,"CHRNAME_TRISTAN","speech","L","MA_01107_300049")

-- ▼直接出力
CloseTalkWindow()
fadeout(0,0,0,1.0, FADE_TIME)
wait_time(FADE_TIME)
Hide(Actor003)
Hide(Actor004)
Hide(Actor005)
 lookat_delay_weight_reset(Actor001,1)
 lookat_delay_weight_reset(Actor002,1)
turn_lookat(Actor001,Actor002,0)
set_enable_auto_lookat_all(false)
setup_small_camera_start()
wait_time(TIME_ELAPSED)
fadein(FADE_TIME)
wait_time(FADE_TIME)
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Sad02")
	change_face(Actor002,"Sad")

	--★★ランスロット★★:…本当のことを伝えるのが正しいかはわからない<br>隠し続けたほうが良いかもわからない
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","MA_01107_300051")

	change_face(Actor002,"Normal")

	--★★ランスロット★★:だがやっと、伝えられることはある<br>すべてではなくとも──…
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","MA_01107_300053")


	--★★ノワール★★:………ランス、ロット…？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01107_300054")

-- ▼直接出力
setup_small_camera_start(Camera002)
change_face(Actor001,"Normal")
-- ▲直接出力
	change_face(Actor002,"Laugh")

	--★★ランスロット★★:今度は俺から頼む、ノワール
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","MA_01107_300055")

-- ▼直接出力
CloseTalkWindow()
-- ▲直接出力
-- ▼直接出力
fadeout(0,0,0,1.0,1.0)
wait_time(1.5)
close_textbox_base()
-- ▲直接出力
-- ▼直接出力
show_image("10101023", 0.0, 0.0, 0.0 ,true,false)
fadein(2.0)
wait_time(1.5)
voiceSignalS = voice_play("VO_MA_01107_300056")
wait_time(1.0)
	while voiceSignalS.IsProccessing() do
		coroutine.yield()
	end
wait_time(1.5)
 --wait_time(3.5)
fadeout(0,0,0,1.0,2.0)
wait_time(2.5)
-- ▲直接出力
	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
load_image_preload("101010140", "content_still_10101014_image", "101010140_StillImage")
load_image_preload("10101023", "content_still_10101023_image", "101010230_StillImage")
	InitializeLoad_Preload()
	load_area_scene_preload(115030)
	InitializeCharacter_3D_Preload("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101010","001","101010001","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("101014","001","101014001","content_animationpack__common","FacialPack","Actor003")
	InitializeCharacter_3D_Preload("101011","001","101011001","content_animationpack__common","FacialPack","Actor004")
	InitializeCharacter_3D_Preload("101012","001","101012001","content_animationpack__common","FacialPack","Actor005")
	InitializeCharacter_2DOnly_Preload("101011","001","101011001")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor004,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor005,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110021_01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
