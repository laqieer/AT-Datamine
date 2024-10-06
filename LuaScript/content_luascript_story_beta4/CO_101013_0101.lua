-- このluaスクリプトは、CO_101013_0101.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110191_03","110191_03_h")
Include("content_adv_advsmall_110191_03","Template110191_03_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos110191_03_008,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName110191_03,CameraPos110191_03_008)
	Camera002 = SetTemplate("Actor002",nil,CharaPos110191_03_002,"content_motion3d_advarea_common_adv_templatecontroller","Chr_003_01_StdController","to Std_Loop",CameraAssetBundleName110191_03,CameraPos110191_03_002)
	Camera003 = SetTemplate("Actor003",nil,CharaPos110191_03_006,"content_motion3d_advarea_common_adv_templatecontroller","Chr_504_01_StdController","to Std_Loop",CameraAssetBundleName110191_03,CameraPos110191_03_006)
	Camera004 = SetTemplate("Actor004",nil,CharaPos110191_03_004,"content_motion3d_advarea_common_adv_templatecontroller","Npc_001_01_StdController","to Std_Loop",CameraAssetBundleName110191_03,CameraPos110191_03_004)
	InitializeTemplateRandomCamera110191_03()
	InitializeTemplate110191_03()
-- ▼直接出力
lookat_delay_weight(Actor002,0.6,0.03,1.0,0.6,0.4)
-- ▲直接出力
-- ▼直接出力
Hide(Actor001)
-- ▲直接出力
-- ▼直接出力
Hide(Actor003)
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(110191)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101013","001","101013001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("101018","001","101018001","content_animationpack__common","FacialPack","Actor003")
	Actor004 = InitializeCharacter_3D("401005","001","401005001","content_animationpack__common","FacialPack","Actor004")
	template1()
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

	PlayAction(Actor004,"to  Std_Joy")
-- ▼直接出力
PlayPartVoice("男子1", "喜び")
-- ▲直接出力

	--★★キャメロット騎士学術院（男）★★:ありがとう～～～っ！あんたはまさに命の恩人だよおおっ！！
	Talk(Actor004,"NPCNAME_0001","speech","N","CO_101013_01010002")

	PlayAction(Actor002,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ガウェイン", "挨拶")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★ガウェイン★★:このぐらいお安い御用だぜまたなにかあったら、いつでも呼んでくれよな
	Talk(Actor002,"CHRNAME_GAWAIN","speech","L","CO_101013_01010004")


	--★★ガウェイン★★:学園のヒーローをさ！
	Talk(Actor002,"CHRNAME_GAWAIN","speech","L","CO_101013_01010006")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor004,"to  Std_Joy")
-- ▼直接出力
PlayPartVoice("男子1", "笑い")
-- ▲直接出力
	change_face(Actor004,"Smile")

	--★★キャメロット騎士学術院（男）★★:本当に助かったよ、ヒーロー！
	Talk(Actor004,"NPCNAME_0001","speech","L","CO_101013_01010007")

	PlayAction(Actor002,"to Greet_one")
-- ▼直接出力
PlayPartVoice("ガウェイン", "肯定")
-- ▲直接出力

	--★★ガウェイン★★:家族は大事にしろよー？
	Talk(Actor002,"CHRNAME_GAWAIN","speech","L","CO_101013_01010008")

-- ▼直接出力
 --時間経過（黒）
CloseTalkWindow()
fadeout(0,0,0,1.0, CHARA_IN_IN)
wait_time(CHARA_IN_IN + CHARA_IN_WAIT)
Hide(Actor004)
Appear(Actor001)
turn_lookat(Actor002,Actor001,0)
wait_time(CHARA_IN_OUT + FADE_AFTER_TIME )
setup_small_camera_start()
fadein(CHARA_IN_OUT)
wait_time(FADE_TIME) 
-- ▲直接出力
	PlayAction(Actor001,"to Greet_one")
-- ▼直接出力
PlayPartVoice("ノワール", "挨拶")
-- ▲直接出力

	--★★ノワール★★:いつもの人助けか
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101013_01010010")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ガウェイン", "肯定2")
-- ▲直接出力
	change_face(Actor002,"Laugh")

	--★★ガウェイン★★:ご名答
	Talk(Actor002,"CHRNAME_GAWAIN","speech","L","CO_101013_01010011")


	--★★ガウェイン★★:あいつが全財産の入った財布を落としてよ
	Talk(Actor002,"CHRNAME_GAWAIN","speech","L","CO_101013_01010013")


	--★★ガウェイン★★:このままだと妹の誕生日プレゼントが買えないって騒いでたから
	Talk(Actor002,"CHRNAME_GAWAIN","speech","L","CO_101013_01010014")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力

	--★★ガウェイン★★:一緒に探してやってたんだよ
	Talk(Actor002,"CHRNAME_GAWAIN","speech","L","CO_101013_01010015")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "肯定3")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★ノワール★★:へえ！それは友達も喜んで当然だな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101013_01010016")

	PlayAction(Actor002,"to  Std_Worry")
-- ▼直接出力
PlayPartVoice("ガウェイン", "驚き")
-- ▲直接出力
	change_face(Actor002,"Surprise")

	--★★ガウェイン★★:友達？
	Talk(Actor002,"CHRNAME_GAWAIN","speech","L","CO_101013_01010017")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:さっきのヤツだよ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101013_01010018")


	--★★ノワール★★:一緒になって財布を探してやったんだ仲のいい友達なんだろ？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101013_01010019")

	PlayAction(Actor002,"to  Std_No")
	change_face(Actor002,"Laugh")

	--★★ガウェイン★★:いや？ほとんど話したことねーぜ
	Talk(Actor002,"CHRNAME_GAWAIN","speech","L","CO_101013_01010020")

	change_face(Actor001,"Surprise")

	--★★ノワール★★:え？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101013_01010021")

-- ▼直接出力
PlayPartVoice("ガウェイン", "笑い")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★ガウェイン★★:困ってる人を助けるときに知り合いか、そうじゃないかは関係ねーだろ
	Talk(Actor002,"CHRNAME_GAWAIN","speech","L","CO_101013_01010022")

-- ▼直接出力
setup_small_camera_start(Camera001)
Appear(Actor003)
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Worry")
-- ▼直接出力
PlayPartVoice("ノワール", "悩む")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:それはそうかもしれないけど…偉いな、感心する
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101013_01010023")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	PlayAction(Actor003,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ラグネル", "肯定")
-- ▲直接出力

	--★★ラグネル★★:ガウェインはヒーローを目指してるからね
	Talk(Actor003,"CHRNAME_RAGNAR","speech","L","CO_101013_01010025")

-- ▼直接出力
PlayPartVoice("ガウェイン", "驚き")
-- ▲直接出力
	change_face(Actor002,"Surprise")

	--★★ガウェイン★★:いつの間に来たんだよ、お前
	Talk(Actor002,"CHRNAME_GAWAIN","speech","L","CO_101013_01010026")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "肯定")
-- ▲直接出力

	--★★ノワール★★:たしかによく言ってるな、ヒーローって
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101013_01010027")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Talk")
	change_face(Actor002,"Laugh")

	--★★ガウェイン★★:ガキみたいだ、って？
	Talk(Actor002,"CHRNAME_GAWAIN","speech","L","CO_101013_01010028")

	play_head_motion(Actor001, "No", 0.3, 1.0, false)

	--★★ノワール★★:いや、そんなことは思ってないよ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101013_01010029")

-- ▼直接出力
PlayPartVoice("ラグネル", "笑い")
-- ▲直接出力
	change_face(Actor003,"Smile")

	--★★ラグネル★★:本物のヒーローをふたりも知っちゃったら自分もそうなりたい、ってなって当然だよね
	Talk(Actor003,"CHRNAME_RAGNAR","speech","L","CO_101013_01010030")

	PlayAction(Actor001,"to  Std_Worry")
-- ▼直接出力
PlayPartVoice("ノワール", "肯定3")
-- ▲直接出力

	--★★ノワール★★:ヒーローがふたり？なんだそれ、詳しく聞きたいな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101013_01010031")

-- ▼直接出力
reserve_next_script("1章/コミュ/x0401_ガウェイン_ランクアップ1_2")
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
	load_area_scene_preload(110191)
	InitializeCharacter_3D_Preload("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101013","001","101013001","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("101018","001","101018001","content_animationpack__common","FacialPack","Actor003")
	InitializeCharacter_3D_Preload("401005","001","401005001","content_animationpack__common","FacialPack","Actor004")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110191_03)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
