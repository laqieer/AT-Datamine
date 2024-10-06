-- このluaスクリプトは、CO_101062_0602.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_112021_03","112021_03_h")
Include("content_adv_advsmall_112021_03","Template112021_03_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos112021_03_002,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName112021_03,CameraPos112021_03_002)
	Camera002 = SetTemplate("Actor002",nil,CharaPos112021_03_001,"content_motion3d_advarea_common_adv_templatecontroller","Npc_012_01_StdController","to Std_Loop",CameraAssetBundleName112021_03,CameraPos112021_03_001)
	InitializeTemplateRandomCamera112021_03()
	InitializeTemplate112021_03()
-- ▼直接出力
load_image("101010140", "content_still_10101014_image", "101010140_StillImage")
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(112021)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101062","001","101062001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_2DOnly("101009","001","101009001")
	template1()
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

-- ▼直接出力
PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力

	--★★ノワール★★:で、話って？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101062_06020002")

	PlayAction(Actor002,"to  Std_Joy")
-- ▼直接出力
PlayPartVoice("マルイル", "笑い")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★マルイル★★:実はですね、なかなか手に入らない<br>稀少な素材の情報をゲットしたんです！
	Talk(Actor002,"CHRNAME_MARIL","speech","L","CO_101062_06020003")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("ノワール", "肯定3")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:へえ。すごいじゃないか<br>仕入れに行かないのか？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101062_06020004")

	PlayAction(Actor002,"to  Std_Worry")
-- ▼直接出力
PlayPartVoice("マルイル", "悩む")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★マルイル★★:もちろん行きたいです！でも…<br>その素材がある場所はかなりの危険地帯なんです
	Talk(Actor002,"CHRNAME_MARIL","speech","L","CO_101062_06020005")


	--★★マルイル★★:いくら鍛えているとはいえ<br>たかが商人のぼくひとりではさすがに…
	Talk(Actor002,"CHRNAME_MARIL","speech","L","CO_101062_06020006")

	PlayAction(Actor002,"to  Std_Sad01")
-- ▼直接出力
PlayPartVoice("マルイル", "否定")
-- ▲直接出力

	--★★マルイル★★:ああ、困ったなあ<br>頼りになる傭兵さんがいればいいのですが…
	Talk(Actor002,"CHRNAME_MARIL","speech","L","CO_101062_06020007")

	change_face(Actor001,"Normal")

	--★★ノワール★★:………
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101062_06020008")

-- ▼直接出力
setup_small_camera_end()
SkipDefaultMotion(Actor002)
PlayActionDirect(Actor002,"to  Std_Sad02")
-- ▲直接出力

	--★★マルイル★★:………チラッ
	Talk(Actor002,"CHRNAME_MARIL","speech","L","CO_101062_06020009")

	PlayAction(Actor001,"to  Std_Worry")
-- ▼直接出力
PlayPartVoice("ノワール", "落胆")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:…そういうことか<br>はぁ…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101062_06020010")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力

	--★★ノワール★★:（…そういやディナタンが面倒ごとを頼むときも<br>こんな感じでチラチラ見てきたっけ）
	Talk(Actor001,"CHRNAME_NOIR","mind","L","CO_101062_06020011")


	--★★ノワール★★:（それにギネヴィアも…）
	Talk(Actor001,"CHRNAME_NOIR","mind","L","CO_101062_06020012")


	--★★ノワール★★:………
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101062_06020014")

	PlayAction(Actor002,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("マルイル", "肯定")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★マルイル★★:ノワールさん、どうかしましたか？
	Talk(Actor002,"CHRNAME_MARIL","speech","L","CO_101062_06020015")

	play_head_motion(Actor001, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "照れ")
-- ▲直接出力

	--★★ノワール★★:いや。末っ子ってやつは…と思っただけ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101062_06020016")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("マルイル", "驚き")
-- ▲直接出力
	change_face(Actor002,"Surprise")

	--★★マルイル★★:はい？
	Talk(Actor002,"CHRNAME_MARIL","speech","L","CO_101062_06020017")

-- ▼直接出力
PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:なんでもない、こっちの話だ<br>わかったよ、付き合ってやるよ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101062_06020018")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Talk")

	--★★ノワール★★:鍛えてるあんたが躊躇するってことは相当危険な場所なんだろうしな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101062_06020019")

	PlayAction(Actor002,"to  Std_Joy")
-- ▼直接出力
PlayPartVoice("マルイル", "挨拶")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★マルイル★★:ノワールさん…ありがとうございます！それじゃ、早速行きましょう！
	Talk(Actor002,"CHRNAME_MARIL","speech","L","CO_101062_06020020")

-- ▼直接出力
CloseTalkWindow()
fadeout(0,0,0,1.0, IMAGE_TIME_IN_OUT)
wait_time(IMAGE_TIME_WAIT_BEFORE + IMAGE_TIME_IN_OUT)
show_image("101010140", 0.0, 0.0, BLACK_WHITE_TIME)
set_scale_image(20,20)
 --Appear(Actor003)
wait_time(BLACK_WHITE_TIME + BLACK_WHITE_WAIT_TIME)
fadein(IMAGE_TIME_IN_IN)
wait_time(IMAGE_TIME_IN_IN)
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("マルイル", "笑い")
-- ▲直接出力

	--★★マルイル★★:ノワールさん、ありました！あれです、目的の白扇花の群生地です！
	Talk(Actor002,"CHRNAME_MARIL","speech","L","CO_101062_06020022")

	change_face(Actor002,"Normal")

	--★★マルイル★★:バルバロイの遺骸を糧にしたことで普通の白扇花とは違う効能を持つそうです
	Talk(Actor002,"CHRNAME_MARIL","speech","L","CO_101062_06020023")

-- ▼直接出力
PlayPartVoice("ノワール", "驚き")
-- ▲直接出力
	change_face(Actor003,"Surprise")

	--★★ノワール02★★:あんな崖っぷちにあるのか…
	Talk(Actor003,"CHRNAME_NOIR","speech","L","CO_101062_06020024")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("マルイル", "肯定2")
-- ▲直接出力

	--★★マルイル★★:ぼくが行って取ってきますノワールさんはここで待っててください！
	Talk(Actor002,"CHRNAME_MARIL","speech","L","CO_101062_06020025")

-- ▼直接出力
PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力

	--★★ノワール02★★:わ、わかった…！
	Talk(Actor003,"CHRNAME_NOIR","speech","L","CO_101062_06020026")

-- ▼直接出力
PlayActionDirect(Actor002,"to Run")
wait_time(1.5)
PlayActionDirect(Actor002,"to Std_Loop")
se_play("SE_ADV_CO_101062_0602_Dotabata")
wait_time(2.0)
se_play("SE_ADV_CO_101062_0602_Dotabata")
wait_time(2.0)
-- ▲直接出力
	open_cutin(1,2)
	on_cutin(1,Actor002,"Smile")
-- ▼直接出力
PlayPartVoice("マルイル", "気合い")
-- ▲直接出力

	--★★マルイル★★:よーっし、ゲットしました～～～～っ！！
	Talk(Actor002,"CHRNAME_MARIL","speech","N","CO_101062_06020028")

	close_cutin()
-- ▼直接出力
PlayPartVoice("ノワール", "落胆")
-- ▲直接出力
	change_face(Actor003,"Sad")

	--★★ノワール02★★:み、見ているこっちがヒヤヒヤする…早くここを離れよう、マルイル…！
	Talk(Actor003,"CHRNAME_NOIR","speech","L","CO_101062_06020030")

-- ▼直接出力
PlayPartVoice("マルイル", "肯定")
-- ▲直接出力

	--★★マルイル★★:はい～っ！
	Talk(Actor002,"CHRNAME_MARIL","speech","L","CO_101062_06020032")

-- ▼直接出力
reserve_next_script("1章/コミュ/x0401_マルイル_ランクアップ6_3")
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
	InitializeLoad_Preload()
	load_area_scene_preload(112021)
	InitializeCharacter_3D_Preload("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101062","001","101062001","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_2DOnly_Preload("101009","001","101009001")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName112021_03)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
