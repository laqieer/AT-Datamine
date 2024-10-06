-- このluaスクリプトは、AV_01_101010.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110111_01","110111_01_h")
Include("content_adv_advsmall_110111_01","Template110111_01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos110111_01_003,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName110111_01,CameraPos110111_01_003)
	Camera002 = SetTemplate("Actor002",nil,CharaPos110111_01_005,"content_motion3d_advarea_common_adv_templatecontroller","Chr_521_01_StdController","to Std_Loop",CameraAssetBundleName110111_01,CameraPos110111_01_005)
	InitializeTemplateRandomCamera110111_01()
	InitializeTemplate110111_01()
-- ▼直接出力
set_common_look_at(Actor002,Actor001)
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_sequence_area_scene(110111)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101001","001","101001001","content_animationpack__common","FacialPack","Actor002")
	template1()
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

-- ▼直接出力
PlayPartVoice("ティルフィング", "挨拶")
-- ▲直接出力

	--★★ティルフィング★★:マスター<br>なにをなさっているのですか？
	Talk(Actor002,"CHRNAME_TYRFING","speech","L","AV_01_101001_0001")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力
	change_face(Actor001,"Laugh")

	--★★ノワール★★:ティルフィングか<br>今は警備の手伝いで、市街の見回りをしてるんだ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","AV_01_101001_0002")

	PlayAction(Actor001,"to  Std_Talk")

	--★★ノワール★★:不審人物がいないかとか<br>揉めごとが起きていないかとかね
	Talk(Actor001,"CHRNAME_NOIR","speech","L","AV_01_101001_0003")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)

	--★★ティルフィング★★:そうでしたか…マスターは人々のため<br>日々尽くされているのですね
	Talk(Actor002,"CHRNAME_TYRFING","speech","L","AV_01_101001_0004")

	play_head_motion(Actor001, "No", 0.3, 1.0, false)

	--★★ノワール★★:俺なんて<br>全然大したことはしてないよ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","AV_01_101001_0005")


	--★★ノワール★★:ティルフィングのほうがずっと立派じゃないか<br>長いあいだ、この島を護ってきてくれたんだから
	Talk(Actor001,"CHRNAME_NOIR","speech","L","AV_01_101001_0006")

	play_head_motion(Actor002, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ティルフィング", "否定")
-- ▲直接出力

	--★★ティルフィング★★:いえ、そんな…<br>それが私の使命でしたから
	Talk(Actor002,"CHRNAME_TYRFING","speech","L","AV_01_101001_0007")

	open_select_window_tag(Actor001,"Normal","AV_01_101001_0008","AV_01_101001_0009","AV_01_101001_0010")
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
	change_face(Actor001,"Laugh")

	--★★ノワール★★:そうだ<br>警備とか見回りのコツがあったら教えてほしい
	Talk(Actor001,"CHRNAME_NOIR","speech","L","AV_01_101001_0012")

	PlayAction(Actor002,"to  Std_Surp")
-- ▼直接出力
PlayPartVoice("ティルフィング", "驚き")
-- ▲直接出力
	change_face(Actor002,"Surprise")

	--★★ティルフィング★★:コ、コツですか？<br>そういわれましても…
	Talk(Actor002,"CHRNAME_TYRFING","speech","L","AV_01_101001_0013")

	change_face(Actor002,"Surprise")

	--★★ティルフィング★★:誰かを護るという意識を絶えずもって<br>周囲の小さな変化も見逃さないように…
	Talk(Actor002,"CHRNAME_TYRFING","speech","L","AV_01_101001_0014")

	change_face(Actor001,"Laugh")

	--★★ノワール★★:………
	Talk(Actor001,"CHRNAME_NOIR","speech","L","AV_01_101001_0015")

	PlayAction(Actor002,"to  Std_Talk")
	change_face(Actor002,"Surprise")

	--★★ティルフィング★★:あの…マスター？<br>私、なにかおかしなことを言っていますか？
	Talk(Actor002,"CHRNAME_TYRFING","speech","L","AV_01_101001_0016")

	change_face(Actor001,"Laugh")

	--★★ノワール★★:いや。その真面目さに<br>俺たちは護られていたんだなって思ってさ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","AV_01_101001_0017")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)

	--★★ノワール★★:見習わなきゃ、キミのこと
	Talk(Actor001,"CHRNAME_NOIR","speech","L","AV_01_101001_0018")

	play_head_motion(Actor002, "No", 0.3, 1.0, false)
	change_face(Actor002,"Laugh")

	--★★ティルフィング★★:私など見習わなくとも<br>マスターはきっとこの島に平和を導けますよ
	Talk(Actor002,"CHRNAME_TYRFING","speech","L","AV_01_101001_0019")

	goto Block1end

::Block1_2::
	CloseTalkWindow()
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
	change_face(Actor001,"Laugh")

	--★★ノワール★★:キミは自分のやってきたことを<br>もっと誇っていいと思う
	Talk(Actor001,"CHRNAME_NOIR","speech","L","AV_01_101001_0021")


	--★★ノワール★★:キミは他の誰にもできないことをやってきた<br>それも、たったひとりで
	Talk(Actor001,"CHRNAME_NOIR","speech","L","AV_01_101001_0022")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ティルフィング", "挨拶")
-- ▲直接出力
	change_face(Actor002,"Laugh")

	--★★ティルフィング★★:…ありがとうございます、マスター
	Talk(Actor002,"CHRNAME_TYRFING","speech","L","AV_01_101001_0023")

	PlayAction(Actor001,"to  Std_Talk")
	change_face(Actor001,"Normal")

	--★★ノワール★★:それで、提案なんだけどさ<br>これからは俺も手伝わせてもらえないかな？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","AV_01_101001_0024")

	change_face(Actor002,"Surprise")

	--★★ティルフィング★★:手伝う？
	Talk(Actor002,"CHRNAME_TYRFING","speech","L","AV_01_101001_0025")


	--★★ノワール★★:キミといっしょにこの島を護っていきたいんだ<br>俺にどこまでできるかはわからないけど
	Talk(Actor001,"CHRNAME_NOIR","speech","L","AV_01_101001_0026")

	change_face(Actor002,"Sad")

	--★★ティルフィング★★:それは…
	Talk(Actor002,"CHRNAME_TYRFING","speech","L","AV_01_101001_0027")

-- ▼直接出力
wait_time(0.5)
-- ▲直接出力
	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ティルフィング", "肯定")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★ティルフィング★★:とても心強いです<br>よろしくお願いします、マスター
	Talk(Actor002,"CHRNAME_TYRFING","speech","L","AV_01_101001_0028")

	goto Block1end

::Block1_3::
	CloseTalkWindow()
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "肯定")
-- ▲直接出力

	--★★ノワール★★:そうだな<br>みんなそれぞれに使命があるんだよな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","AV_01_101001_0030")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ティルフィング", "肯定")
-- ▲直接出力
	change_face(Actor002,"Laugh")

	--★★ティルフィング★★:はい。マスターには<br>私よりも遥かに大きな使命があるはずです
	Talk(Actor002,"CHRNAME_TYRFING","speech","L","AV_01_101001_0031")


	--★★ティルフィング★★:その時が来るまで<br>どうか１日１日を大切に過ごしてください
	Talk(Actor002,"CHRNAME_TYRFING","speech","L","AV_01_101001_0032")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力
	change_face(Actor001,"Laugh")

	--★★ノワール★★:ああ、わかったよ<br>ティルフィング
	Talk(Actor001,"CHRNAME_NOIR","speech","L","AV_01_101001_0033")

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
	InitializeCharacter_3D_Preload("101001","001","101001001","content_animationpack__common","FacialPack","Actor002")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110111_01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
