-- このluaスクリプトは、PT2_01C_02_001.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110901_01","110901_01_h")
Include("content_adv_advsmall_110901_01","Template110901_01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos110901_01_003,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName110901_01,CameraPos110901_01_003)
	Camera002 = SetTemplate("Actor002",nil,CharaPos110901_01_005,"content_motion3d_advarea_common_adv_templatecontroller","Chr_004_01_StdController","to Std_Loop",CameraAssetBundleName110901_01,CameraPos110901_01_005)
	InitializeTemplateRandomCamera110901_01()
	InitializeTemplate110901_01()
-- ▼直接出力
turn_lookat(Actor002,Actor001,0)
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(115910)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101014","001","101014001","content_animationpack__common","FacialPack","Actor002")
	template1()
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("トリスタン","挨拶")
-- ▲直接出力

	--★★トリスタン★★:ひとつ聞いてもいいかな
	Talk(Actor002,"CHRNAME_TRISTAN","speech","L","PT2_01C_02_0010002")

-- ▼直接出力
PlayPartVoice("ノワール","肯定2")
-- ▲直接出力

	--★★ノワール★★:なんだ？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT2_01C_02_0010003")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("トリスタン","悩む")
-- ▲直接出力

	--★★トリスタン★★:継承者の使命から逃げ出したいと<br>思ったことはない？
	Talk(Actor002,"CHRNAME_TRISTAN","speech","L","PT2_01C_02_0010004")


	--★★トリスタン★★:もしキミが継承者でなければ<br>戦わずにすんだはずだよね
	Talk(Actor002,"CHRNAME_TRISTAN","speech","L","PT2_01C_02_0010005")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)

	--★★トリスタン★★:ランスロットとも、ギネヴィアとも<br>そしてアーサーとも
	Talk(Actor002,"CHRNAME_TRISTAN","speech","L","PT2_01C_02_0010006")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール","落胆")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:もちろん最初は<br>どうして俺がと恨んださ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT2_01C_02_0010007")

	PlayAction(Actor001,"to  Std_Talk")
	change_face(Actor001,"Normal")

	--★★ノワール★★:でも、みんなが手を差し伸べてくれたから<br>ここまで走り続けることができた
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT2_01C_02_0010008")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("ノワール","肯定2")
-- ▲直接出力

	--★★ノワール★★:それに、誰かがやらなくちゃいけなくて<br>俺が選ばれたんだったら
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT2_01C_02_0010009")

	PlayAction(Actor001,"to  Std_Joy")

	--★★ノワール★★:逃げるわけにはいかない<br>同じ苦しみを誰かに押し付けたくはないからな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT2_01C_02_0010010")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("トリスタン","納得")
-- ▲直接出力

	--★★トリスタン★★:模範回答だね<br>なんの面白みもない
	Talk(Actor002,"CHRNAME_TRISTAN","speech","L","PT2_01C_02_0010011")

-- ▼直接出力
PlayPartVoice("ノワール","落胆")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:まだ俺を疑ってるのか？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT2_01C_02_0010012")

	play_head_motion(Actor002, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("トリスタン","怒り")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★トリスタン★★:ちょっとショックだな
	Talk(Actor002,"CHRNAME_TRISTAN","speech","L","PT2_01C_02_0010013")


	--★★トリスタン★★:キミはまだ<br>ボクがキミを疑ってるかもなんて思ってるの？
	Talk(Actor002,"CHRNAME_TRISTAN","speech","L","PT2_01C_02_0010014")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
	change_face(Actor002,"Normal")

	--★★トリスタン★★:キミはこれまで<br>一度として逃げたことはなかった
	Talk(Actor002,"CHRNAME_TRISTAN","speech","L","PT2_01C_02_0010015")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力

	--★★トリスタン★★:継承者という役目を盾に<br>戦わないことだってできたはずなのにね
	Talk(Actor002,"CHRNAME_TRISTAN","speech","L","PT2_01C_02_0010016")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール","肯定2")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:聖杯が壊された以上<br>もうその手は使えないな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT2_01C_02_0010017")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("トリスタン","肯定")
-- ▲直接出力

	--★★トリスタン★★:そのとおりだね<br>継承者という肩書にもはや意味はない
	Talk(Actor002,"CHRNAME_TRISTAN","speech","L","PT2_01C_02_0010018")


	--★★トリスタン★★:だからもう、キミがひとりで<br>背負いこむ必要もないんだ
	Talk(Actor002,"CHRNAME_TRISTAN","speech","L","PT2_01C_02_0010019")


	--★★ノワール★★:トリスタン…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT2_01C_02_0010020")

	PlayAction(Actor002,"to  Std_Talk")

	--★★トリスタン★★:泣いても笑っても<br>もうすぐ最後の戦いだ
	Talk(Actor002,"CHRNAME_TRISTAN","speech","L","PT2_01C_02_0010021")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("トリスタン","挨拶")
-- ▲直接出力

	--★★トリスタン★★:今までキミが背負ってきた痛みや苦しみ<br>少しはボクにも分けてよ
	Talk(Actor002,"CHRNAME_TRISTAN","speech","L","PT2_01C_02_0010022")

	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	InitializeLoad_Preload()
	load_area_scene_preload(115910)
	InitializeCharacter_3D_Preload("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101014","001","101014001","content_animationpack__common","FacialPack","Actor002")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110901_01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
