-- このluaスクリプトは、EA_001_043.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110051_02","110051_02_h")
Include("content_adv_advsmall_110051_02","Template110051_02_h")
Include("content_adv_advsmall_110051_02","110051_02_h")
Include("content_adv_advsmall_110051_02","Template110051_02_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",180,CharaPos110051_02_013,"content_motion3d_advarea_common_adv_templatecontroller","Npc_008_01_StdController","to Std_Loop",CameraAssetBundleName110051_02,CameraPos110051_02_013)
	Camera002 = SetTemplate("Actor002",nil,CharaPos110051_02_005,"content_motion3d_advarea_common_adv_templatecontroller","Chr_005_01_SitController","to Sit01_Loop",CameraAssetBundleName110051_02,CameraPos110051_02_005)
	Camera003 = SetTemplate("Actor003",nil,CharaPos110051_02_020,"content_motion3d_advarea_common_adv_templatecontroller","Chr_026_01_StdController","to Std_Loop",CameraAssetBundleName110051_02,CameraPos110051_02_020)
	InitializeTemplateRandomCamera110051_02()
	InitializeTemplate110051_02()
-- ▼直接出力
RndCamera001 =  RndCamera009
-- ▲直接出力
-- ▼直接出力
CameraEx_01 = set_camera({3.88, 2.81, -9.55,   14.5, 322.4, 0,   20})
-- ▲直接出力
-- ▼直接出力
load_image("104000210", "content_still_10400021_image", "104000210_StillImage")
-- ▲直接出力
end
function template2()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos110051_02_014,"content_motion3d_advarea_common_adv_templatecontroller","Npc_008_01_StdController","to Std_Loop",CameraAssetBundleName110051_02,CameraPos110051_02_014)
	Camera002 = SetTemplate("Actor002",nil,CharaPos110051_02_005,"content_motion3d_advarea_common_adv_templatecontroller","Chr_005_01_SitController","to Sit01_Loop",CameraAssetBundleName110051_02,CameraPos110051_02_005)
	InitializeTemplateRandomCamera110051_02()
	InitializeTemplate110051_02()
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(110051)
	Actor001 = InitializeCharacter_3D("101040","001","101040001","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101015","001","101015001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("401035","001","401035001","content_animationpack__common","FacialPack","Actor003")
	template1()
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor003,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

-- ▼直接出力
PlayPartVoice("ケイ","肯定2")
-- ▲直接出力

	--★★ケイ★★:ずいぶん…身なりが整ったものだ
	Talk(Actor001,"CHRNAME_KAY","speech","L","EA_001_043002")

-- ▼直接出力
CloseTalkWindow()
setup_small_camera_start(Camera003)
-- ▲直接出力
	PlayAction(Actor003,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("兵士3","肯定")
-- ▲直接出力

	--★★ログレス兵★★:…事実、手芸サークル部長の──ラグネルの<br>裁縫の腕は元より群を抜いておりました
	Talk(Actor003,"NPCNAME_0124","speech","N","EA_001_043003")

-- ▼直接出力
ShowImageItem(104000210)
-- ▲直接出力

	--★★ログレス兵★★:へ、兵の力自慢をもってしても<br>アップリケは取り外せないほど丈夫で──
	Talk(Actor003,"NPCNAME_0124","speech","N","EA_001_043004")

-- ▼直接出力
CloseTalkWindow()
HideImageItem()
setup_small_camera_start(CameraEx_01)
-- ▲直接出力
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ケイ","肯定")
-- ▲直接出力

	--★★ケイ★★:それで
	Talk(Actor001,"CHRNAME_KAY","speech","L","EA_001_043005")

	PlayAction(Actor003,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("兵士3","肯定2")
-- ▲直接出力

	--★★ログレス兵★★:今朝においては…さらに<br>ラグネルが我らの意見を聴取してきました
	Talk(Actor003,"NPCNAME_0124","speech","N","EA_001_043006")

	PlayAction(Actor001,"to  Std_Talk")

	--★★ケイ★★:意見の聴取？<br>ラグネルが貴公らになにを聞くと？
	Talk(Actor001,"CHRNAME_KAY","speech","L","EA_001_043007")


	--★★ログレス兵★★:………服のサイズや<br>ファッションの悩みなど、です
	Talk(Actor003,"NPCNAME_0124","speech","N","EA_001_043008")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
-- ▼直接出力
SkipDefaultMotion(Actor001)
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Worry")
-- ▼直接出力
PlayPartVoiceDirect("ケイ","0015")
-- ▲直接出力

	--★★ケイ★★:…ほう
	Talk(Actor001,"CHRNAME_KAY","speech","L","EA_001_043009")

	play_head_motion(Actor003, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("兵士3","肯定")
-- ▲直接出力

	--★★ログレス兵★★:兵の服のほつれや破損は固く縫い合わされ<br>ダメージの多い箇所は適切な補強が…
	Talk(Actor003,"NPCNAME_0124","speech","N","EA_001_043010")

-- ▼直接出力
setup_small_camera_start(RndCamera009)
-- ▲直接出力
	PlayAction(Actor003,"to  Std_Talk")

	--★★ログレス兵★★:さらに、兵それぞれの体型に合ったカタチ<br>彼らの要求に応えた調整が施され──
	Talk(Actor003,"NPCNAME_0124","speech","N","EA_001_043011")

-- ▼直接出力
PlayPartVoice("兵士3","悩む")
-- ▲直接出力

	--★★ログレス兵★★:しかも超速、かつ的確な裁縫で…です<br>そして、なんと申せばよいか…
	Talk(Actor003,"NPCNAME_0124","speech","N","EA_001_043012")

-- ▼直接出力
PlayActionDirect(Actor001,"to Std_Loop")
-- ▲直接出力

	--★★ケイ★★:申せ
	Talk(Actor001,"CHRNAME_KAY","speech","L","EA_001_043013")


	--★★ログレス兵★★:みな…とても、ファッショナブルで──
	Talk(Actor003,"NPCNAME_0124","speech","N","EA_001_043014")

-- ▼直接出力
PlayPartVoice("ケイ","肯定")
-- ▲直接出力

	--★★ケイ★★:貴公も見たところ<br>満足げな表情をしているな
	Talk(Actor001,"CHRNAME_KAY","speech","L","EA_001_043015")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
-- ▼直接出力
SkipDefaultMotion(Actor003)
-- ▲直接出力
	PlayAction(Actor003,"to  Std_Joy")
-- ▼直接出力
PlayPartVoice("兵士3","笑い")
-- ▲直接出力

	--★★ログレス兵★★:い、いやぁ、こう…<br>鏡を見たくなるというかですねえ
	Talk(Actor003,"NPCNAME_0124","speech","N","EA_001_043016")


	--★★ログレス兵★★:ノワール卿の力量も文句ありません<br>最近の若い者は骨のあるヤツが多いですなあ
	Talk(Actor003,"NPCNAME_0124","speech","N","EA_001_043017")

-- ▼直接出力
setup_small_camera_start(CameraEx_01)
-- ▲直接出力
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ケイ","肯定3")
-- ▲直接出力

	--★★ケイ★★:もう良い。下がりたまえ
	Talk(Actor001,"CHRNAME_KAY","speech","L","EA_001_043018")

-- ▼直接出力
PlayActionDirect(Actor003,"to Std_Loop")
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("兵士3","肯定2")
-- ▲直接出力

	--★★ログレス兵★★:は、ハッ
	Talk(Actor003,"NPCNAME_0124","speech","N","EA_001_043019")

-- ▼直接出力
CloseTalkWindow()
-- ▲直接出力
-- ▼直接出力
fadeout(0,0,0,1.0, FADE_TIME)
-- ▲直接出力
-- ▼直接出力
wait_time(FADE_TIME)
-- ▲直接出力
-- ▼直接出力
se_play("SE_ADV_MA_01B900_06_Door_Close")
-- ▲直接出力
-- ▼直接出力
Hide(Actor003)
-- ▲直接出力
-- ▼直接出力
template2()
-- ▲直接出力
-- ▼直接出力
setup_small_camera_start(Camera001)
-- ▲直接出力
-- ▼直接出力
wait_time(TIME_ELAPSED)
-- ▲直接出力
-- ▼直接出力
fadein(FADE_TIME)
-- ▲直接出力
-- ▼直接出力
wait_time(FADE_TIME)
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("ケイ","落胆")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ケイ★★:服装の乱れは心の乱れ<br>とは言うものの──
	Talk(Actor001,"CHRNAME_KAY","speech","L","EA_001_043021")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("アーサー","笑い")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★アーサー★★:ファッションがキマって気を良くしているな！
	Talk(Actor002,"CHRNAME_ARTHUR","speech","L","EA_001_043022")

	change_face(Actor002,"Normal")

	--★★アーサー★★:ガワが荒れていれば<br>メンタルも整わんということだなあ
	Talk(Actor002,"CHRNAME_ARTHUR","speech","L","EA_001_043024")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
-- ▼直接出力
SkipDefaultMotion(Actor001)
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Worry")
-- ▼直接出力
PlayPartVoice("ケイ","悩む")
-- ▲直接出力

	--★★ケイ★★:ここ最近は兵に休みも出してやれていなかった<br>学生に戦を任せることへの不満も溜まっていたが
	Talk(Actor001,"CHRNAME_KAY","speech","L","EA_001_043025")

-- ▼直接出力
PlayPartVoice("アーサー","肯定2")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★アーサー★★:晴れ晴れさせてしまったな！
	Talk(Actor002,"CHRNAME_ARTHUR","speech","L","EA_001_043026")

	change_face(Actor001,"Normal")

	--★★ケイ★★:服の直しひとつで──
	Talk(Actor001,"CHRNAME_KAY","speech","L","EA_001_043028")

-- ▼直接出力
PlayPartVoice("アーサー","肯定3")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★アーサー★★:イゾルデが兵を連れ出したことも<br>見て見ぬフリしていたな？義兄さんは
	Talk(Actor002,"CHRNAME_ARTHUR","speech","L","EA_001_043029")

-- ▼直接出力
PlayActionDirect(Actor001,"to Std_Loop")
-- ▲直接出力
	play_head_motion(Actor001, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ケイ","否定")
-- ▲直接出力

	--★★ケイ★★:知らんよ、そんなことは
	Talk(Actor001,"CHRNAME_KAY","speech","L","EA_001_043030")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	play_head_motion(Actor002, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("アーサー","笑い")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★アーサー★★:またまたあ
	Talk(Actor002,"CHRNAME_ARTHUR","speech","L","EA_001_043031")

	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ケイ","肯定2")
-- ▲直接出力

	--★★ケイ★★:兵装を勝手にアレンジするのはいかがなものか<br>とも思うが、それはまた別の話か
	Talk(Actor001,"CHRNAME_KAY","speech","L","EA_001_043032")

	change_face(Actor001,"Smile")

	--★★ケイ★★:口先だけかと思っていたが<br>──なかなかどうして手先も器用だ
	Talk(Actor001,"CHRNAME_KAY","speech","L","EA_001_043034")

	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
RndCamera001 =  RndCamera009
load_image_preload("104000210", "content_still_10400021_image", "104000210_StillImage")
	InitializeLoad_Preload()
	load_area_scene_preload(110051)
	InitializeCharacter_3D_Preload("101040","001","101040001","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101015","001","101015001","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("401035","001","401035001","content_animationpack__common","FacialPack","Actor003")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor003,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110051_02)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
