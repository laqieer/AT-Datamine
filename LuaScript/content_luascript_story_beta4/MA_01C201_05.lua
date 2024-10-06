-- このluaスクリプトは、MA_01C201_05.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110061_01","110061_01_h")
Include("content_adv_advsmall_110061_01","Template110061_01_h")
-- ▼直接出力
MobsNo = 0
-- ▲直接出力
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos110061_01_002,"content_motion3d_advarea_common_adv_templatecontroller","Chr_501_01_StdController","to Std_Loop",CameraAssetBundleName110061_01,CameraPos110061_01_002)
	Camera002 = SetTemplate("Actor002",nil,CharaPos110061_01_005,"content_motion3d_advarea_common_adv_templatecontroller","Chr_507_01_StdController","to Std_Loop",CameraAssetBundleName110061_01,CameraPos110061_01_005)
	InitializeTemplateRandomCamera110061_01()
	InitializeTemplate110061_01()
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(115061)
	Actor001 = InitializeCharacter_3D("101012","001","101012001","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101017","001","101017001","content_animationpack__common","FacialPack","Actor002")
	template1()
-- ▼直接出力
MobsNo = 0
-- ▲直接出力
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

-- ▼直接出力
wait_time(1.5)
-- ▲直接出力

	--★★マルディサント★★:もう歌わないのか？
	Talk(Actor002,"CHRNAME_MALADISANT","speech","L","MA_01C201_050002")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
	change_face(Actor001,"Sad")

	--★★ディナタン★★:うん<br>今はそんな気分じゃなくて
	Talk(Actor001,"CHRNAME_DINATAN","speech","L","MA_01C201_050003")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力

	--★★ディナタン★★:…ねえ、忘れることは罪かな
	Talk(Actor001,"CHRNAME_DINATAN","speech","L","MA_01C201_050004")

	PlayAction(Actor002,"to  Std_Talk")

	--★★マルディサント★★:なんだそれ<br>また夢でも見たのか
	Talk(Actor002,"CHRNAME_MALADISANT","speech","L","MA_01C201_050005")

	play_head_motion(Actor001, "No", 0.3, 1.0, false)
	change_face(Actor001,"Normal")

	--★★ディナタン★★:ううん。最近、夢は見ないの
	Talk(Actor001,"CHRNAME_DINATAN","speech","L","MA_01C201_050006")


	--★★ディナタン★★:もしかしたら、目を覚まして<br>忘れてるだけかもしれないけど
	Talk(Actor001,"CHRNAME_DINATAN","speech","L","MA_01C201_050007")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
	change_face(Actor001,"Sad")

	--★★ディナタン★★:でも、夢なら別に忘れてたっていい
	Talk(Actor001,"CHRNAME_DINATAN","speech","L","MA_01C201_050008")

-- ▼直接出力
wait_time(0.5)
setup_small_camera_end()
-- ▲直接出力
	play_head_motion(Actor002, "No", 0.3, 1.0, false)

	--★★マルディサント★★:…記憶がなくなっても<br>事実がなくなるわけじゃない
	Talk(Actor002,"CHRNAME_MALADISANT","speech","L","MA_01C201_050010")


	--★★マルディサント★★:記憶が消えても記録は残る<br>思いも残る、きっと
	Talk(Actor002,"CHRNAME_MALADISANT","speech","L","MA_01C201_050011")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力

	--★★ディナタン★★:…そうかな
	Talk(Actor001,"CHRNAME_DINATAN","speech","L","MA_01C201_050012")


	--★★ディナタン★★:残るのかな、ちゃんと
	Talk(Actor001,"CHRNAME_DINATAN","speech","L","MA_01C201_050013")

	PlayAction(Actor001,"to  Std_Sad02")

	--★★ディナタン★★:夢を見ない代わりに<br>最近、いろんなことを考えてる
	Talk(Actor001,"CHRNAME_DINATAN","speech","L","MA_01C201_050014")


	--★★ディナタン★★:それから思い出す
	Talk(Actor001,"CHRNAME_DINATAN","speech","L","MA_01C201_050015")


	--★★マルディサント★★:…なにを？
	Talk(Actor002,"CHRNAME_MALADISANT","speech","L","MA_01C201_050016")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力

	--★★ディナタン★★:兄さんのこと
	Talk(Actor001,"CHRNAME_DINATAN","speech","L","MA_01C201_050017")


	--★★マルディサント★★:思いを感じる？
	Talk(Actor002,"CHRNAME_MALADISANT","speech","L","MA_01C201_050018")

-- ▼直接出力
wait_time(0.5)
setup_small_camera_start()
-- ▲直接出力
	play_head_motion(Actor001, "No", 0.3, 1.0, false)
	change_face(Actor001,"Surprise")

	--★★ディナタン★★:…それだけじゃなくて――<br>あっ…
	Talk(Actor001,"CHRNAME_DINATAN","speech","L","MA_01C201_050019")

-- ▼直接出力
wait_time(0.5)
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ディナタン★★:…マァルも感じる？
	Talk(Actor001,"CHRNAME_DINATAN","speech","L","MA_01C201_050020")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
	change_face(Actor002,"Sad")

	--★★マルディサント★★:…少しは<br>でもそばにいりゃわかるだろ、大体
	Talk(Actor002,"CHRNAME_MALADISANT","speech","L","MA_01C201_050021")


	--★★ディナタン★★:…そうだよね…
	Talk(Actor001,"CHRNAME_DINATAN","speech","L","MA_01C201_050022")

	play_head_motion(Actor002, "No", 0.3, 1.0, false)
	change_face(Actor002,"Normal")

	--★★マルディサント★★:思いそのものが<br>流れ込んでくるわけじゃない
	Talk(Actor002,"CHRNAME_MALADISANT","speech","L","MA_01C201_050023")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力

	--★★マルディサント★★:だからそれが本当の思いなのかは<br>わからない
	Talk(Actor002,"CHRNAME_MALADISANT","speech","L","MA_01C201_050024")


	--★★ディナタン★★:…そうかな…そうかも
	Talk(Actor001,"CHRNAME_DINATAN","speech","L","MA_01C201_050025")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
-- ▼直接出力
SkipDefaultMotion(Actor001)
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Sad01")

	--★★ディナタン★★:ねぇ、マァル<br>私…どうしたら………
	Talk(Actor001,"CHRNAME_DINATAN","speech","L","MA_01C201_050027")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)

	--★★マルディサント★★:今ディーナが抱えている思いを<br>もっと大事にしてもかまわないはずだ
	Talk(Actor002,"CHRNAME_MALADISANT","speech","L","MA_01C201_050028")

-- ▼直接出力
PlayActionDirect(Actor001,"to Std_Loop")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ディナタン★★:そうかな…そうだといいな?
	Talk(Actor001,"CHRNAME_DINATAN","speech","L","MA_01C201_050029")

	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	InitializeLoad_Preload()
	load_area_scene_preload(115061)
	InitializeCharacter_3D_Preload("101012","001","101012001","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101017","001","101017001","content_animationpack__common","FacialPack","Actor002")
MobsNo = 0
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110061_01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
