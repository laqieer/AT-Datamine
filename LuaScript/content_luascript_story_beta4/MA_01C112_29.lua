-- このluaスクリプトは、MA_01C112_29.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110041_02","110041_02_h")
Include("content_adv_advsmall_110041_02","Template110041_02_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",35,CharaPos110041_02_003,"content_motion3d_advarea_common_adv_templatecontroller","Chr_501_01_StdController","to Std_Loop",CameraAssetBundleName110041_02,CameraPos110041_02_003)
	Camera002 = SetTemplate("Actor002",nil,CharaPos110041_02_002,"content_motion3d_advarea_common_adv_templatecontroller","Chr_507_01_StdController","to Std_Loop",CameraAssetBundleName110041_02,CameraPos110041_02_002)
	InitializeTemplateRandomCamera110041_02()
	InitializeTemplate110041_02()
-- ▼直接出力
load_image("10104023", "content_still_10104023_image", "101040230_StillImage")
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(110041)
	Actor001 = InitializeCharacter_3D("101012","001","101012001","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101017","001","101017001","content_animationpack__common","FacialPack","Actor002")
	template1()
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

	PlayAction(Actor001,"to  Std_Talk")

	--★★ディナタン★★:夢を見たの<br>聞いてくれる？
	Talk(Actor001,"CHRNAME_DINATAN","speech","L","MA_01C112_290002")

	play_head_motion(Actor002, "No", 0.3, 1.0, false)
	change_face(Actor002,"Sad")

	--★★マルディサント★★:…またかよ
	Talk(Actor002,"CHRNAME_MALADISANT","speech","L","MA_01C112_290003")

-- ▼直接出力
setup_small_camera_start(RndCamera008)
-- ▲直接出力
-- ▼直接出力
turn_chara(Actor002,150,0)
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Joy")

	--★★ディナタン★★:恋に落ちたふたりは別れてしまう<br>でも子供が生まれるの
	Talk(Actor001,"CHRNAME_DINATAN","speech","L","MA_01C112_290004")


	--★★マルディサント★★:別れたのに生まれるってどういうことだよ
	Talk(Actor002,"CHRNAME_MALADISANT","speech","L","MA_01C112_290005")


	--★★ディナタン★★:子供は大切に森の奥で育てられて…
	Talk(Actor001,"CHRNAME_DINATAN","speech","L","MA_01C112_290006")

	PlayAction(Actor002,"to  Std_Angry")
	open_cutin(1,1)
	on_cutin(1,Actor002,"Anger")

	--★★マルディサント★★:あああ！もう！<br>やめろよそのクソ辛気臭え話！
	Talk(Actor002,"CHRNAME_MALADISANT","speech","N","MA_01C112_290007")

	close_cutin()
	change_face(Actor001,"Surprise")

	--★★ディナタン★★:え…？
	Talk(Actor001,"CHRNAME_DINATAN","speech","L","MA_01C112_290008")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	play_head_motion(Actor002, "No", 0.3, 1.0, false)

	--★★マルディサント★★:うんざりなんだよ<br>アンタのその夢の話は！
	Talk(Actor002,"CHRNAME_MALADISANT","speech","L","MA_01C112_290009")

	play_head_motion(Actor001, "No", 0.3, 1.0, false)
	change_face(Actor001,"Sad")

	--★★ディナタン★★:…でも、でもね<br>その夢は――
	Talk(Actor001,"CHRNAME_DINATAN","speech","L","MA_01C112_290010")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Talk")
	change_face(Actor002,"Sad")

	--★★マルディサント★★:夢くらいアタシも見るよ	<br>けど全然覚えちゃいねえ
	Talk(Actor002,"CHRNAME_MALADISANT","speech","L","MA_01C112_290011")

	change_face(Actor002,"Anger")

	--★★マルディサント★★:起きたら忘れるんだ、夢ってのは<br>それでいいだろうが！
	Talk(Actor002,"CHRNAME_MALADISANT","speech","L","MA_01C112_290012")

	PlayAction(Actor002,"to  Std_Angry")

	--★★マルディサント★★:夢に操られてんじゃねえよ！
	Talk(Actor002,"CHRNAME_MALADISANT","speech","L","MA_01C112_290013")


	--★★ディナタン★★:マァル…
	Talk(Actor001,"CHRNAME_DINATAN","speech","L","MA_01C112_290014")

-- ▼直接出力
wait_time(1.3)
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Sad02")
	change_face(Actor002,"Sad")

	--★★マルディサント★★:…悪い
	Talk(Actor002,"CHRNAME_MALADISANT","speech","L","MA_01C112_290015")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	PlayAction(Actor001,"to  Std_No")

	--★★ディナタン★★:ううん。私が悪いの
	Talk(Actor001,"CHRNAME_DINATAN","speech","L","MA_01C112_290016")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
	change_face(Actor001,"Normal")

	--★★ディナタン★★:そうだよね<br>誰かの夢の話とか、面白くないもんね
	Talk(Actor001,"CHRNAME_DINATAN","speech","L","MA_01C112_290017")

	PlayAction(Actor001,"to  Std_Talk")

	--★★ディナタン★★:夢ってほら、荒唐無稽っていうか<br>ご都合主義？みたいなとこもあるし
	Talk(Actor001,"CHRNAME_DINATAN","speech","L","MA_01C112_290018")

	change_face(Actor001,"Sad")

	--★★ディナタン★★:………
	Talk(Actor001,"CHRNAME_DINATAN","speech","L","MA_01C112_290019")

-- ▼直接出力
setup_small_camera_start(RndCamera001)
SkipDefaultMotion(Actor001)
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Worry")

	--★★ディナタン★★:…私ね、この学園に来るまで<br>バイブスもキラーズも知らなかった
	Talk(Actor001,"CHRNAME_DINATAN","speech","L","MA_01C112_290020")


	--★★ディナタン★★:大切な人と繋がって<br>武器になって戦うなんて
	Talk(Actor001,"CHRNAME_DINATAN","speech","L","MA_01C112_290021")

-- ▼直接出力
PlayAction(Actor001,"to  Std_Talk")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ディナタン★★:兄さんの武器になって戦うなんて<br>…そんな夢みたいな話
	Talk(Actor001,"CHRNAME_DINATAN","speech","L","MA_01C112_290022")


	--★★マルディサント★★:………
	Talk(Actor002,"CHRNAME_MALADISANT","speech","L","MA_01C112_290023")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)

	--★★ディナタン★★:継承者もバイブスもキラーズも妖精も聖杯も<br>ぜんぶぜんぶ、夢みたい
	Talk(Actor001,"CHRNAME_DINATAN","speech","L","MA_01C112_290024")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
	change_face(Actor002,"Normal")

	--★★マルディサント★★:そうだな<br>とんだ悪夢だぜ
	Talk(Actor002,"CHRNAME_MALADISANT","speech","L","MA_01C112_290025")

	play_head_motion(Actor002, "No", 0.3, 1.0, false)
	change_face(Actor002,"Sad")

	--★★マルディサント★★:こんな夢みたいな話にすがるしか<br>戦うすべがねえなんて
	Talk(Actor002,"CHRNAME_MALADISANT","speech","L","MA_01C112_290026")

-- ▼直接出力
setup_small_camera_end()
SkipDefaultMotion(Actor001)
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Sad01")
	change_face(Actor001,"Sad")

	--★★ディナタン★★:全部忘れちゃってもいいのにね…
	Talk(Actor001,"CHRNAME_DINATAN","speech","L","MA_01C112_290027")

-- ▼直接出力
setup_small_camera_start(RndCamera008)
-- ▲直接出力
	change_face(Actor002,"Surprise")

	--★★マルディサント★★:ディーナ？
	Talk(Actor002,"CHRNAME_MALADISANT","speech","L","MA_01C112_290028")


	--★★ディナタン★★:忘れてしまったほうがいいことも<br>たくさんある気がする…
	Talk(Actor001,"CHRNAME_DINATAN","speech","L","MA_01C112_290029")

	change_face(Actor002,"Sad")

	--★★マルディサント★★:アンタの体調が悪いのも<br>その夢のせいなのか？
	Talk(Actor002,"CHRNAME_MALADISANT","speech","L","MA_01C112_290030")

	play_head_motion(Actor001, "No", 0.3, 1.0, false)

	--★★ディナタン★★:…わからない…
	Talk(Actor001,"CHRNAME_DINATAN","speech","L","MA_01C112_290031")

-- ▼直接出力
CloseTalkWindow()
-- ▲直接出力
-- ▼直接出力
fadeout(0,0,0,1.0,1.0)
wait_time(1.5)
close_textbox_base()
-- ▲直接出力
-- ▼直接出力
show_image("10104023", 0.0, 0.0, 0.0 ,true,false)
fadein(2.0)
wait_time(1.5)
 voiceSignalS = voice_play("VO_story01_D_0734")
wait_time(1.0)
	while voiceSignalS.IsProccessing() do
		coroutine.yield()
	end
wait_time(1.5)
fadeout(0,0,0,1.0,2.0)
wait_time(2.5)
-- ▲直接出力
	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
load_image_preload("10104023", "content_still_10104023_image", "101040230_StillImage")
	InitializeLoad_Preload()
	load_area_scene_preload(110041)
	InitializeCharacter_3D_Preload("101012","001","101012001","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101017","001","101017001","content_animationpack__common","FacialPack","Actor002")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110041_02)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
