-- このluaスクリプトは、PT3_01C_09_002.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110191_01","110191_01_h")
Include("content_adv_advsmall_110191_01","Template110191_01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos110191_01_004,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName110191_01,CameraPos110191_01_004)
	Camera002 = SetTemplate("Actor002",nil,CharaPos110191_01_002,"content_motion3d_advarea_common_adv_templatecontroller","Chr_003_01_StdController","to Std_Loop",CameraAssetBundleName110191_01,CameraPos110191_01_002)
	InitializeTemplateRandomCamera110191_01()
	InitializeTemplate110191_01()
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(110191)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101013","001","101013001","content_animationpack__common","FacialPack","Actor002")
	template1()
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

-- ▼直接出力
PlayPartVoice("ガウェイン", "挨拶")
-- ▲直接出力
	change_face(Actor002,"Laugh")

	--★★ガウェイン★★:そーいやさ、やってなかったよな<br>ノワールがＧＳを果たしたお祝い
	Talk(Actor002,"CHRNAME_GAWAIN","speech","L","PT3_01C_09_002002")

	PlayAction(Actor002,"to  Std_Joy")
	change_face(Actor002,"Smile")

	--★★ガウェイン★★:一発、でっけーパーティでも開くか？<br>ガレスに美味いモン作ってもらってよ
	Talk(Actor002,"CHRNAME_GAWAIN","speech","L","PT3_01C_09_002003")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "笑い")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★ノワール★★:ありがとう<br>気持ちだけでじゅうぶんだよ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT3_01C_09_002004")

-- ▼直接出力
PlayPartVoice("ガウェイン", "肯定3")
-- ▲直接出力
	change_face(Actor002,"Surprise")

	--★★ガウェイン★★:そうか？ちょっとくらいハメ外しても<br>アーサー様は許してくれると思うけどなー
	Talk(Actor002,"CHRNAME_GAWAIN","speech","L","PT3_01C_09_002005")

	PlayAction(Actor002,"to  Std_Talk")
	change_face(Actor002,"Smile")

	--★★ガウェイン★★:あっ、俺は先輩マスターだからな<br>わかんないことがあったらなんでも聞けよ！
	Talk(Actor002,"CHRNAME_GAWAIN","speech","L","PT3_01C_09_002006")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("ノワール", "驚き")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:先輩マスター…？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT3_01C_09_002007")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ガウェイン", "肯定")
-- ▲直接出力
	change_face(Actor002,"Laugh")

	--★★ガウェイン★★:俺のほうが先にＧＳしてるから<br>ノワールより先輩！な？
	Talk(Actor002,"CHRNAME_GAWAIN","speech","L","PT3_01C_09_002008")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Talk")
	change_face(Actor001,"Normal")

	--★★ノワール★★:…じゃあ、センパイ。ＧＳしたことによる<br>バイブスとキラーズの共鳴による相互認識の…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT3_01C_09_002009")

	PlayAction(Actor002,"to  Std_Worry")
	change_face(Actor002,"Surprise")

	--★★ガウェイン★★:ちょちょちょちょーっと待て！<br>なんか小難しいこと聞こうとしてないか！？
	Talk(Actor002,"CHRNAME_GAWAIN","speech","L","PT3_01C_09_002010")

-- ▼直接出力
PlayPartVoice("ノワール", "喜び")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★ノワール★★:センパイならなんでも答えてくれるんだろ？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT3_01C_09_002011")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	PlayAction(Actor002,"to  Std_No")

	--★★ガウェイン★★:ごめんごめん、嘘！先輩辞める！<br>俺とお前はクラスメイト！ダチ！
	Talk(Actor002,"CHRNAME_GAWAIN","speech","L","PT3_01C_09_002012")

	PlayAction(Actor001,"to  Std_Worry")
-- ▼直接出力
PlayPartVoice("ノワール", "悩む")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:…やれやれ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT3_01C_09_002013")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ガウェイン", "笑い")
-- ▲直接出力
	change_face(Actor002,"Laugh")

	--★★ガウェイン★★:とにかく、お前が継承者になろうと<br>なんになろうと、俺はダチだから！
	Talk(Actor002,"CHRNAME_GAWAIN","speech","L","PT3_01C_09_002014")

	change_face(Actor002,"Smile")

	--★★ガウェイン★★:そこんとこ、しっかり覚えとけよ！
	Talk(Actor002,"CHRNAME_GAWAIN","speech","L","PT3_01C_09_002015")

	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	InitializeLoad_Preload()
	load_area_scene_preload(110191)
	InitializeCharacter_3D_Preload("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101013","001","101013001","content_animationpack__common","FacialPack","Actor002")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110191_01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
