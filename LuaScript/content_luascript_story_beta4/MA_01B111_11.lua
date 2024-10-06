-- このluaスクリプトは、MA_01B111_11.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110021_01","110021_01_h")
Include("content_adv_advsmall_110021_01","Template110021_01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos110021_01_002,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName110021_01,CameraPos110021_01_002)
	Camera002 = SetTemplate("Actor002",nil,CharaPos110021_01_005,"content_motion3d_advarea_common_adv_templatecontroller","Npc_008_01_StdController","to Std_Loop",CameraAssetBundleName110021_01,CameraPos110021_01_005)
	InitializeTemplateRandomCamera110021_01()
	InitializeTemplate110021_01()
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(110021)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101040","001","101040001","content_animationpack__common","FacialPack","Actor002")
	template1()
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

-- ▼直接出力
 --PlayPartVoice("ケイ", "怒り")
-- ▲直接出力
	change_face(Actor002,"Anger")

	--★★ケイ★★:ああ忙しい忙しい忙しい忙しい
	Talk(Actor002,"CHRNAME_KAY","speech","L","MA_01B111_110002")

	PlayAction(Actor002,"to  Std_Angry")

	--★★ケイ★★:忙しいよ、まったく！！
	Talk(Actor002,"CHRNAME_KAY","speech","L","MA_01B111_110004")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
-- ▼直接出力
 --PlayPartVoice("ケイ", "肯定2")
-- ▲直接出力

	--★★ケイ★★:我が王の公務がこれほどまでとは<br>予想だにしていなかったよ！！
	Talk(Actor002,"CHRNAME_KAY","speech","L","MA_01B111_110005")

	PlayAction(Actor002,"to  Std_Worry")

	--★★ケイ★★:いやまったく！！<br>私個人の仕事も残っているんだがね！！
	Talk(Actor002,"CHRNAME_KAY","speech","L","MA_01B111_110006")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	open_select_window_tag(Actor001,"Normal","MA_01B111_110007","MA_01B111_110008")
	if is_select(1) then
		goto Block1_1
	elseif is_select(2) then
		goto Block1_2
	end

::Block1_1::
	CloseTalkWindow()
	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
 --PlayPartVoice("ノワール", "悩む")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:あの…なにか手伝いましょうか
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01B111_110010")

	change_face(Actor001,"Surprise")

	--★★ノワール★★:アーサーと同じで<br>デスクワークはそんなに、ですけど…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01B111_110011")

	play_head_motion(Actor002, "No", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("ケイ", "否定")
-- ▲直接出力
	change_face(Actor002,"Anger")

	--★★ケイ★★:貴公は全力で休みたまえ！<br>今のは八つ当たりだ！失礼！
	Talk(Actor002,"CHRNAME_KAY","speech","L","MA_01B111_110012")

	goto Block1end

::Block1_2::
	CloseTalkWindow()
-- ▼直接出力
 --PlayPartVoice("ノワール", "喜び")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★ノワール★★:義弟想いなんですね
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01B111_110014")

	PlayAction(Actor002,"to  Std_No")
-- ▼直接出力
 --PlayPartVoice("ケイ", "否定")
-- ▲直接出力
	change_face(Actor002,"Anger")

	--★★ケイ★★:勘違いも甚だしい！<br>私は国のためにやっているだけだ！
	Talk(Actor002,"CHRNAME_KAY","speech","L","MA_01B111_110015")

	change_face(Actor002,"Anger")

	--★★ケイ★★:私が見てやらねばこの国はまわらん！<br>他国から「あの国の王は…」とバカにされる！
	Talk(Actor002,"CHRNAME_KAY","speech","L","MA_01B111_110016")

-- ▼直接出力
 --PlayPartVoice("ノワール", "笑い")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★ノワール★★:そういう気持ち<br>家族なら意外に感じているものですよ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01B111_110017")

-- ▼直接出力
 --PlayPartVoice("ケイ", "落胆")
-- ▲直接出力
	change_face(Actor002,"Anger")

	--★★ケイ★★:それなら労いの言葉があってもいいと思うがね！<br>義兄の心、義弟知らずというやつだ！
	Talk(Actor002,"CHRNAME_KAY","speech","L","MA_01B111_110019")

	goto Block1end

::Block1end::
-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Talk")
	change_face(Actor002,"Anger")

	--★★ケイ★★:なにか聞きたそうだな！！ン！？<br>私は今とても忙しいんだがね！！ン！？
	Talk(Actor002,"CHRNAME_KAY","speech","L","MA_01B111_110021")

-- ▼直接出力
 --PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:あ、ああ、えーと、アーサーは、どこに…？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01B111_110022")

-- ▼直接出力
 --PlayPartVoice("ケイ", "怒り")
-- ▲直接出力

	--★★ケイ★★:療養中だよ！
	Talk(Actor002,"CHRNAME_KAY","speech","L","MA_01B111_110023")


	--★★ケイ★★:大怪我からの発熱続きに加え<br>近頃は慢性的に体調が優れんらしい！
	Talk(Actor002,"CHRNAME_KAY","speech","L","MA_01B111_110025")

-- ▼直接出力
DontChangeRandomCamera(true)
-- ▲直接出力
-- ▼直接出力
setup_small_camera_start(Camera002)
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Worry")
-- ▼直接出力
 --PlayPartVoice("ケイ", "肯定2")
-- ▲直接出力

	--★★ケイ★★:B級グルメばかり口にして<br>栄養が偏ったと私は見るがね！！
	Talk(Actor002,"CHRNAME_KAY","speech","L","MA_01B111_110026")


	--★★ケイ★★:貴公もグラストンベリーに訪れてみるといい！<br>自然は心も体も癒してくれる、絶好の療養場だ！
	Talk(Actor002,"CHRNAME_KAY","speech","L","MA_01B111_110027")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
-- ▼直接出力
turn(Actor002,0,-34,0,0.3)
-- ▲直接出力
-- ▼直接出力
 --PlayPartVoice("ケイ", "挨拶")
-- ▲直接出力

	--★★ケイ★★:お大事に！！
	Talk(Actor002,"CHRNAME_KAY","speech","L","MA_01B111_110028")


	--★★ノワール★★:（…ずっと怒ってるのに<br>全部教えてくれたな…）
	Talk(Actor001,"CHRNAME_NOIR","mind","L","MA_01B111_110030")

-- ▼直接出力
setup_small_camera_start(Camera002)
-- ▲直接出力
-- ▼直接出力
turn(Actor002,0,-124,0,0.3)
-- ▲直接出力
-- ▼直接出力
 --PlayPartVoice("ケイ", "笑い")
-- ▲直接出力

	--★★ケイ★★:マーリンがいれば<br>学園への帰りもスムーズだ！
	Talk(Actor002,"CHRNAME_KAY","speech","L","MA_01B111_110032")

	PlayAction(Actor002,"to  Std_Talk")

	--★★ケイ★★:すぐに出陣出来るよう<br>緊張を保つのも良いことだがね！！
	Talk(Actor002,"CHRNAME_KAY","speech","L","MA_01B111_110033")


	--★★ケイ★★:グラストンベリーは良い所だぞ！！
	Talk(Actor002,"CHRNAME_KAY","speech","L","MA_01B111_110034")

-- ▼直接出力
CloseTalkWindow()
-- ▲直接出力
-- ▼直接出力
fadeout(0,0,0,1.0, CHARA_IN_IN)
-- ▲直接出力
-- ▼直接出力
wait_time(CHARA_IN_IN)
-- ▲直接出力
-- ▼直接出力
se_play("SE_ADV_MA_01B900_06_Door_Close")
-- ▲直接出力
-- ▼直接出力
wait_time(CHARA_IN_WAIT)
-- ▲直接出力
-- ▼直接出力
Hide(Actor002)
-- ▲直接出力
-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
-- ▼直接出力
fadein(CHARA_IN_OUT)
-- ▲直接出力
-- ▼直接出力
wait_time(CHARA_IN_OUT)
-- ▲直接出力
-- ▼直接出力
wait_time(1.0)
-- ▲直接出力
-- ▼直接出力
setup_small_camera_start(Camera001)
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:（………行って休めってことか？）
	Talk(Actor001,"CHRNAME_NOIR","mind","L","MA_01B111_110036")

	open_cutin(1,2)
	on_cutin(1,Actor002,"Anger")
-- ▼直接出力
 --PlayPartVoice("ケイ", "怒り")
-- ▲直接出力

	--★★ケイ★★:多忙で休む暇もないな！！<br>こんなことなら暇な日に休むべきであったな！！
	Talk(Actor002,"CHRNAME_KAY","speech","N","MA_01B111_110038")

	close_cutin()
	PlayAction(Actor001,"to  Std_Sad01")

	--★★ノワール★★:（ヘタだ…気遣いが…）
	Talk(Actor001,"CHRNAME_NOIR","mind","L","MA_01B111_110039")

	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	InitializeLoad_Preload()
	load_area_scene_preload(110021)
	InitializeCharacter_3D_Preload("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101040","001","101040001","content_animationpack__common","FacialPack","Actor002")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110021_01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
