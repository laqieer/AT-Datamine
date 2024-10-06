-- このluaスクリプトは、CO_101015_0002.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110101_01","110101_01_h")
Include("content_adv_advsmall_110101_01","Template110101_01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos110101_01_006,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName110101_01,CameraPos110101_01_006)
	Camera002 = SetTemplate("Actor002",180,CharaPos110101_01_003,"content_motion3d_advarea_common_adv_templatecontroller","Chr_005_01_StdController","to Std_Loop",CameraAssetBundleName110101_01,CameraPos110101_01_003)
	InitializeTemplateRandomCamera110101_01()
	InitializeTemplate110101_01()
-- ▼直接出力
turn_lookat(Actor001,Actor002,0)
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(110101)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101015","001","101015001","content_animationpack__common","FacialPack","Actor002")
	template1()
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

	change_face(Actor002,"Serious")

	--★★アーサー★★:…………
	Talk(Actor002,"CHRNAME_ARTHUR","speech","L","CO_101015_00010008")


	--★★ノワール★★:（…ずいぶん熱心に祈ってるな）
	Talk(Actor001,"CHRNAME_NOIR","mind","L","CO_101015_00010009")

-- ▼直接出力
setup_small_camera_start()
PlayActionDirect(Actor002,"to Wlk")
turn_chara(Actor002,-53.7,0.5)
wait_time(0.5)
PlayActionDirect(Actor002,"to Std_Loop")
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("アーサー", "肯定3")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★アーサー★★:――ああ、すまない待たせてしまったな
	Talk(Actor002,"CHRNAME_ARTHUR","speech","L","CO_101015_00010010")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)

	--★★ノワール★★:いや、別にいいけど…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101015_00010011")

	open_select_window_tag(Actor001,"Normal","CO_101015_00010012","CO_101015_00010013","CO_101015_00010014")
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

	--★★ノワール★★:ここにはよく来るのか？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101015_00010016")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("アーサー", "肯定2")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★アーサー★★:そう頻繁というわけではないがなこう見えて、それなりに多忙なんだ
	Talk(Actor002,"CHRNAME_ARTHUR","speech","L","CO_101015_00010017")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Sad01")
	change_face(Actor002,"Smile")

	--★★アーサー★★:ふと祈りたくなったときに足を運ぶそれだけだよ
	Talk(Actor002,"CHRNAME_ARTHUR","speech","L","CO_101015_00010018")

	PlayAction(Actor001,"to  Std_Worry")
-- ▼直接出力
PlayPartVoice("ノワール", "肯定3")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:祈りたくなったとき…？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101015_00010019")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("アーサー", "肯定")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★アーサー★★:神様は面白く思っていないかもな？都合のいいときだけ頼りおって、と
	Talk(Actor002,"CHRNAME_ARTHUR","speech","L","CO_101015_00010020")

-- ▼直接出力
setup_small_camera_start(RndCamera009)
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ノワール", "肯定")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★ノワール★★:…でも、そういうもんじゃないか神頼みってやつはさ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101015_00010021")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("アーサー", "笑い")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★アーサー★★:はは。違いない
	Talk(Actor002,"CHRNAME_ARTHUR","speech","L","CO_101015_00010022")

	goto Block1end

::Block1_2::
	CloseTalkWindow()
-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ノワール", "肯定3")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:意外だな神頼みをするタイプには見えなかった
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101015_00010024")

	PlayAction(Actor002,"to  Std_Surp")
	change_face(Actor002,"Surprise")

	--★★アーサー★★:そう見えるか？
	Talk(Actor002,"CHRNAME_ARTHUR","speech","L","CO_101015_00010025")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:あああんたって意外と現実主義なとこあるだろ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101015_00010026")

	PlayAction(Actor001,"to  Std_Talk")
	change_face(Actor001,"Normal")

	--★★ノワール★★:神様に任せるくらいなら自分が全部引き受けるって言いそうだと思って
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101015_00010027")

	PlayAction(Actor002,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("アーサー", "笑い")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★アーサー★★:ハハハ！そう言ってくれるのは嬉しいがそれは買い被りというものだ
	Talk(Actor002,"CHRNAME_ARTHUR","speech","L","CO_101015_00010028")

	PlayAction(Actor002,"to  Std_Worry")
-- ▼直接出力
PlayPartVoice("アーサー", "悲しみ")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★アーサー★★:俺もそんな王でありたいが…
	Talk(Actor002,"CHRNAME_ARTHUR","speech","L","CO_101015_00010029")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★アーサー★★:あいにく、まだそこまで思い切れてなくてね…神頼みを止められそうにないよ
	Talk(Actor002,"CHRNAME_ARTHUR","speech","L","CO_101015_00010030")

	change_face(Actor001,"Sad")

	--★★ノワール★★:………
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101015_00010031")

	PlayAction(Actor001,"to  Std_Talk")
	change_face(Actor001,"Normal")

	--★★ノワール★★:あのさ…神頼みを否定するわけじゃないけどたまには仲間に相談するのもいいんじゃないか？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101015_00010032")

-- ▼直接出力
PlayPartVoice("ノワール", "悲しみ")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:そりゃ、あんたに比べたら俺はまだまだ頼りないかもしれないけど
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101015_00010033")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
	change_face(Actor001,"Normal")

	--★★ノワール★★:少しくらいは力になれる…んじゃないかなと思ってる
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101015_00010034")

-- ▼直接出力
PlayPartVoice("アーサー", "驚き")
-- ▲直接出力
	change_face(Actor002,"Surprise")

	--★★アーサー★★:ノワール…
	Talk(Actor002,"CHRNAME_ARTHUR","speech","L","CO_101015_00010035")

-- ▼直接出力
setup_small_camera_start(RndCamera007)
-- ▲直接出力
	play_head_motion(Actor001, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "笑い")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★ノワール★★:…って、なにいきなり語ってんだろう、俺
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101015_00010036")

	PlayAction(Actor001,"to  Std_Talk")
	change_face(Actor001,"Normal")

	--★★ノワール★★:あんたが柄にもないことするから調子狂った忘れてくれ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101015_00010037")

	PlayAction(Actor002,"to  Std_Joy")
-- ▼直接出力
PlayPartVoice("アーサー", "笑い")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★アーサー★★:フッ…確かに、お互いにらしくなかったかもしれないな
	Talk(Actor002,"CHRNAME_ARTHUR","speech","L","CO_101015_00010038")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("アーサー", "肯定2")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★アーサー★★:だが、なかなか悪くない時間だった
	Talk(Actor002,"CHRNAME_ARTHUR","speech","L","CO_101015_00010039")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
	change_face(Actor002,"Smile")

	--★★アーサー★★:だから、忘れないさ大切に覚えておくよ
	Talk(Actor002,"CHRNAME_ARTHUR","speech","L","CO_101015_00010040")

	goto Block1end

::Block1_3::
	CloseTalkWindow()
	PlayAction(Actor001,"to  Std_Talk")
	change_face(Actor001,"Normal")

	--★★ノワール★★:そんなに熱心に、なにを祈ってたんだ？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101015_00010043")

	PlayAction(Actor002,"to  Std_No")
-- ▼直接出力
PlayPartVoice("アーサー", "否定")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★アーサー★★:おっと、ノワール<br>こういうのは人に明かすものではないぞ？
	Talk(Actor002,"CHRNAME_ARTHUR","speech","L","CO_101015_00010044")

	change_face(Actor001,"Surprise")

	--★★ノワール★★:え、そうなのか？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101015_00010045")

	PlayAction(Actor002,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("アーサー", "肯定3")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★アーサー★★:そうとも！願いが叶わなくなってしまうからな！
	Talk(Actor002,"CHRNAME_ARTHUR","speech","L","CO_101015_00010046")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★アーサー★★:…というのは冗談だが
	Talk(Actor002,"CHRNAME_ARTHUR","speech","L","CO_101015_00010047")

	PlayAction(Actor002,"to  Std_Sad01")
	change_face(Actor002,"Normal")

	--★★アーサー★★:実際、人に話せるものではない祈りは己との対話だ
	Talk(Actor002,"CHRNAME_ARTHUR","speech","L","CO_101015_00010048")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
setup_small_camera_start()
PlayPartVoice("アーサー", "笑い")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★アーサー★★:誰にも話せないからこそ、祈るのさ
	Talk(Actor002,"CHRNAME_ARTHUR","speech","L","CO_101015_00010049")

	PlayAction(Actor001,"to  Std_Worry")
-- ▼直接出力
PlayPartVoice("ノワール", "肯定3")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:そういうものか…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101015_00010050")

	goto Block1end

::Block1end::
-- ▼直接出力
kizuna_gaugeup(Actor002,"アーサー")
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
	load_area_scene_preload(110101)
	InitializeCharacter_3D_Preload("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101015","001","101015001","content_animationpack__common","FacialPack","Actor002")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110101_01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
