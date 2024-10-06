-- このluaスクリプトは、AV_01_101014.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110111_01","110111_01_h")
Include("content_adv_advsmall_110111_01","Template110111_01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos110111_01_003,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName110111_01,CameraPos110111_01_003)
	Camera002 = SetTemplate("Actor002",40,CharaPos110111_01_005,"content_motion3d_advarea_common_adv_templatecontroller","Chr_004_01_StdController","to Std_Loop",CameraAssetBundleName110111_01,CameraPos110111_01_005)
	InitializeTemplateRandomCamera110111_01()
	InitializeTemplate110111_01()
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_sequence_area_scene(110111)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101014","001","101014001","content_animationpack__common","FacialPack","Actor002")
	template1()
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()


	--★★トリスタン★★:驚いたよ<br>本当にキミがいるなんてね
	Talk(Actor002,"CHRNAME_TRISTAN","speech","L","AV_01_101014_0001")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力

	--★★ノワール★★:トリスタン…<br>お前も市街の見回りか？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","AV_01_101014_0002")


	--★★トリスタン★★:まさか
	Talk(Actor002,"CHRNAME_TRISTAN","speech","L","AV_01_101014_0003")


	--★★トリスタン★★:知り合いの兵士から<br>キミによく似た人がいるって聞いたものでね
	Talk(Actor002,"CHRNAME_TRISTAN","speech","L","AV_01_101014_0004")

	play_head_motion(Actor001, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "肯定3")
-- ▲直接出力

	--★★ノワール★★:わざわざ確認しに来たのか？<br>それはそれはご苦労なことで
	Talk(Actor001,"CHRNAME_NOIR","speech","L","AV_01_101014_0005")

-- ▼直接出力
PlayPartVoice("トリスタン", "落胆")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★トリスタン★★:手伝いとはいえ<br>警備の仕事を遊び半分でやられちゃ困るからね
	Talk(Actor002,"CHRNAME_TRISTAN","speech","L","AV_01_101014_0006")

	PlayAction(Actor002,"to  Std_Talk")
-- ▼直接出力
set_common_look_at(Actor002,Actor001)
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★トリスタン★★:他の兵士たちに迷惑をかけてないか<br>見に来てあげたってわけ
	Talk(Actor002,"CHRNAME_TRISTAN","speech","L","AV_01_101014_0007")

	open_select_window_tag(Actor001,"Normal","AV_01_101014_0008","AV_01_101014_0009","AV_01_101014_0010")
	if is_select(1) then
		goto Block1_1
	elseif is_select(2) then
		goto Block1_2
	elseif is_select(3) then
		goto Block1_3
	end

::Block1_1::
	CloseTalkWindow()
	PlayAction(Actor001,"to  Std_Talk")
	change_face(Actor001,"Normal")

	--★★ノワール★★:誰にも迷惑はかけてないし<br>ちゃんとやってるよ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","AV_01_101014_0012")

	play_head_motion(Actor002, "No", 0.3, 1.0, false)
-- ▼直接出力
wait_time(0.5)
-- ▲直接出力
	change_face(Actor002,"Serious")

	--★★トリスタン★★:嫌いだね<br>そういう言いかた
	Talk(Actor002,"CHRNAME_TRISTAN","speech","L","AV_01_101014_0013")

	PlayAction(Actor002,"to  Std_Talk")
	change_face(Actor002,"Serious")

	--★★トリスタン★★:真摯に向き合おうとしている人間は<br>おいそれとそんな言葉を口にしないものさ
	Talk(Actor002,"CHRNAME_TRISTAN","speech","L","AV_01_101014_0014")

	PlayAction(Actor001,"to  Std_Surp")
-- ▼直接出力
PlayPartVoice("ノワール", "苦しみ")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:うっ…<br>わ、悪かったよ…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","AV_01_101014_0015")

-- ▼直接出力
PlayPartVoice("トリスタン", "挨拶")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★トリスタン★★:いつまでもボクの相手してる場合じゃないでしょ<br>警備の仕事に戻りなよ
	Talk(Actor002,"CHRNAME_TRISTAN","speech","L","AV_01_101014_0016")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
	change_face(Actor001,"Sad")

	--★★ノワール★★:あ、ああ…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","AV_01_101014_0017")

	goto Block1end

::Block1_2::
	CloseTalkWindow()
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "悩む")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:始めてそんなに経ってないから<br>まだまだみんなに迷惑をかけてると思う
	Talk(Actor001,"CHRNAME_NOIR","speech","L","AV_01_101014_0019")

	change_face(Actor002,"Normal")

	--★★トリスタン★★:ふうん…<br>殊勝なもんじゃない
	Talk(Actor002,"CHRNAME_TRISTAN","speech","L","AV_01_101014_0020")

-- ▼直接出力
PlayPartVoice("トリスタン", "挨拶")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★トリスタン★★:特別にアドバイスしてあげようか？
	Talk(Actor002,"CHRNAME_TRISTAN","speech","L","AV_01_101014_0021")

-- ▼直接出力
PlayPartVoice("ノワール", "驚き")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:アドバイス？<br>トリスタンが？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","AV_01_101014_0022")

	change_face(Actor002,"Normal")

	--★★トリスタン★★:ボクは哨戒だったり偵察だったりの<br>任務を担当することが多いからね
	Talk(Actor002,"CHRNAME_TRISTAN","speech","L","AV_01_101014_0023")

	PlayAction(Actor002,"to  Std_Talk")
	change_face(Actor002,"Serious")

	--★★トリスタン★★:いいかい？<br>異変を見て探そうとするだけじゃダメだ
	Talk(Actor002,"CHRNAME_TRISTAN","speech","L","AV_01_101014_0024")

	change_face(Actor002,"Serious")

	--★★トリスタン★★:変化は音にも現れる<br>小さな音も聞き逃さないように耳を澄ませて
	Talk(Actor002,"CHRNAME_TRISTAN","speech","L","AV_01_101014_0025")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "納得")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:眼だけでなく耳でも異変を探るのか<br>なるほどな、勉強になったよ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","AV_01_101014_0026")

	change_face(Actor002,"Smile")

	--★★トリスタン★★:すぐにはできないだろうけどね<br>頑張ってみて
	Talk(Actor002,"CHRNAME_TRISTAN","speech","L","AV_01_101014_0027")

	goto Block1end

::Block1_3::
	CloseTalkWindow()
	change_face(Actor001,"Normal")

	--★★ノワール★★:せっかくだし<br>トリスタンも一緒にやっていかないか？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","AV_01_101014_0029")

-- ▼直接出力
PlayPartVoice("トリスタン", "驚き")
-- ▲直接出力
	change_face(Actor002,"Surprise")

	--★★トリスタン★★:はぁ？<br>なんでそうなるわけ？
	Talk(Actor002,"CHRNAME_TRISTAN","speech","L","AV_01_101014_0030")

	change_face(Actor002,"Surprise")

	--★★トリスタン★★:ボクは誰と誰がケンカしようが<br>まったく興味ないんだけど
	Talk(Actor002,"CHRNAME_TRISTAN","speech","L","AV_01_101014_0031")

	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ノワール", "笑い")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★ノワール★★:ケンカの仲裁は俺がやるからさ<br>トリスタンは他に異変が起きないか見てくれよ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","AV_01_101014_0032")

-- ▼直接出力
PlayPartVoice("トリスタン", "落胆")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★トリスタン★★:あのさあ…
	Talk(Actor002,"CHRNAME_TRISTAN","speech","L","AV_01_101014_0033")

	play_head_motion(Actor002, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("トリスタン", "苦しみ")
-- ▲直接出力
	change_face(Actor002,"Anger")

	--★★トリスタン★★:ああ、もう！<br>特別に少しだけ付き合ってあげるよ
	Talk(Actor002,"CHRNAME_TRISTAN","speech","L","AV_01_101014_0034")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★ノワール★★:ありがとう<br>助かるよ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","AV_01_101014_0035")

	goto Block1end

::Block1end::
-- ▼直接出力
local commu = system.GetCommu() -- 実行中コミュ
local commuChara = commu.GetCharacter()
kizuna_gaugeup_encount(Actor002,commuChara.CharaName)
-- ▲直接出力
	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	InitializeLoad_Preload()
	load_sequence_area_scene_preload(110111)
	InitializeCharacter_3D_Preload("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101014","001","101014001","content_animationpack__common","FacialPack","Actor002")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110111_01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
