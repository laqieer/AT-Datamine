-- このluaスクリプトは、AV_01_101010.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_112031_01","112031_01_h")
Include("content_adv_advsmall_112031_01","Template112031_01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos112031_01_003,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName112031_01,CameraPos112031_01_003)
	Camera002 = SetTemplate("Actor002",nil,CharaPos112031_01_004,"content_motion3d_advarea_common_adv_templatecontroller","Chr_001_01_StdController","to Std_Loop",CameraAssetBundleName112031_01,CameraPos112031_01_004)
	InitializeTemplateRandomCamera112031_01()
	InitializeTemplate112031_01()
-- ▼直接出力
set_common_look_at(Actor002,Actor001)
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_sequence_area_scene(112031)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101010","001","101010001","content_animationpack__common","FacialPack","Actor002")
	template1()
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()


	--★★ランスロット★★:ノワール？<br>ここでなにをしているんだ？
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","AV_01_101010_0001")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)

	--★★ノワール★★:見てわかるだろ？<br>店の手伝いだよ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","AV_01_101010_0002")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ランスロット", "肯定2")
-- ▲直接出力

	--★★ランスロット★★:なるほど、そうか
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","AV_01_101010_0003")

	PlayAction(Actor002,"to  Std_Talk")

	--★★ランスロット★★:ところで、ヴォールスはいるだろうか？<br>話があって来たんだが
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","AV_01_101010_0004")


	--★★ノワール★★:今は買い出しに行ってるけど…<br>あんたとヴォールスって仲が良いのか？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","AV_01_101010_0005")


	--★★ランスロット★★:…お前からはどう見えるんだ？
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","AV_01_101010_0006")

	open_select_window_tag(Actor001,"Normal","AV_01_101010_0007","AV_01_101010_0008","AV_01_101010_0009")
	if is_select(1) then
		goto Block1_1
	elseif is_select(2) then
		goto Block1_2
	elseif is_select(3) then
		goto Block1_3
	end

::Block1_1::
	CloseTalkWindow()
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "肯定")
-- ▲直接出力
	change_face(Actor001,"Laugh")

	--★★ノワール★★:仲が良さそうに見える、かな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","AV_01_101010_0011")

	PlayAction(Actor001,"to  Std_Talk")
	change_face(Actor001,"Laugh")

	--★★ノワール★★:あんたもヴォールスも<br>口数が多いほうじゃないし愛想も良くないけど
	Talk(Actor001,"CHRNAME_NOIR","speech","L","AV_01_101010_0012")

	change_face(Actor001,"Laugh")

	--★★ノワール★★:円卓会議でのやりとりを見てるかぎり<br>お互いの考えてることがわかってる感じがする
	Talk(Actor001,"CHRNAME_NOIR","speech","L","AV_01_101010_0013")

	change_face(Actor002,"Normal")

	--★★ランスロット★★:…そうか
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","AV_01_101010_0014")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
	change_face(Actor002,"Laugh")

	--★★ランスロット★★:ヴォールスとはともに稽古を<br>することが多くてな
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","AV_01_101010_0015")

	change_face(Actor002,"Laugh")

	--★★ランスロット★★:自然と互いの呼吸が読めるようになった<br>ただ…
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","AV_01_101010_0016")

	change_face(Actor001,"Normal")

	--★★ノワール★★:ただ？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","AV_01_101010_0017")

	PlayAction(Actor002,"to  Std_Worry")
-- ▼直接出力
PlayPartVoice("ランスロット", "悩む")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★ランスロット★★:俺とヴォールスは<br>そんなに口数が少なく、愛想が悪いだろうか？
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","AV_01_101010_0018")

	change_face(Actor001,"Normal")

	--★★ノワール★★:（一応、気にはするのか…）
	Talk(Actor001,"CHRNAME_NOIR","mind","L","AV_01_101010_0019")

	goto Block1end

::Block1_2::
	CloseTalkWindow()
	PlayAction(Actor001,"to  Std_Worry")
-- ▼直接出力
PlayPartVoice("ノワール", "悩む")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:仲が良さそうには見えないな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","AV_01_101010_0021")

	change_face(Actor002,"Sad")

	--★★ランスロット★★:…お前からはそう見えるのか
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","AV_01_101010_0022")

	PlayAction(Actor001,"to  Std_Talk")
	change_face(Actor001,"Normal")

	--★★ノワール★★:なんとなくだけどさ<br>…違うのか？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","AV_01_101010_0023")

-- ▼直接出力
PlayPartVoice("ランスロット", "悩む")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★ランスロット★★:俺はヴォールスのことを信頼しているし<br>意見がぶつかった経験もないが
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","AV_01_101010_0024")

	PlayAction(Actor002,"to  Std_Worry")
	change_face(Actor002,"Sad")

	--★★ランスロット★★:ひょっとして<br>ヴォールスが気を使ってくれていたのだろうか？
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","AV_01_101010_0025")

	change_face(Actor002,"Sad")

	--★★ランスロット★★:…あとで聞いてみることにしよう
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","AV_01_101010_0026")

	change_face(Actor001,"Sad")

	--★★ノワール★★:（なんか俺、余計なこと言っちゃったかな…）
	Talk(Actor001,"CHRNAME_NOIR","mind","L","AV_01_101010_0027")

	goto Block1end

::Block1_3::
	CloseTalkWindow()
	change_face(Actor001,"Normal")

	--★★ノワール★★:あんたとヴォールスの仲か<br>そんなこと、気にしたことがなかったな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","AV_01_101010_0029")

	PlayAction(Actor001,"to  Std_Talk")
	change_face(Actor001,"Normal")

	--★★ノワール★★:昔からあんたは<br>ひとりでいることが多かったから
	Talk(Actor001,"CHRNAME_NOIR","speech","L","AV_01_101010_0030")

	change_face(Actor001,"Normal")

	--★★ノワール★★:必要以上に<br>誰かと親しくなろうとしないのかと思ってた
	Talk(Actor001,"CHRNAME_NOIR","speech","L","AV_01_101010_0031")

	change_face(Actor002,"Normal")

	--★★ランスロット★★:…そう見えていたのか
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","AV_01_101010_0032")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "笑い")
-- ▲直接出力
	change_face(Actor001,"Laugh")

	--★★ノワール★★:変わったんだな、あんたも
	Talk(Actor001,"CHRNAME_NOIR","speech","L","AV_01_101010_0033")

	PlayAction(Actor002,"to  Std_Worry")
	change_face(Actor002,"Laugh")

	--★★ランスロット★★:変わったというよりは<br>変えてもらった、という表現が正しいのだろうな
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","AV_01_101010_0034")

	PlayAction(Actor001,"to  Std_Talk")
	change_face(Actor001,"Surprise")

	--★★ノワール★★:変えてもらった？<br>誰にだ？ヴォールスか？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","AV_01_101010_0035")

-- ▼直接出力
PlayPartVoice("ランスロット", "笑い")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★ランスロット★★:誰にだろうな
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","AV_01_101010_0036")

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
	load_sequence_area_scene_preload(112031)
	InitializeCharacter_3D_Preload("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101010","001","101010001","content_animationpack__common","FacialPack","Actor002")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName112031_01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
