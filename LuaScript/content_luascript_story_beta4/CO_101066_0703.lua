-- このluaスクリプトは、CO_101066_0703.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110111_01","110111_01_h")
Include("content_adv_advsmall_110111_01","Template110111_01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos110111_01_003,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName110111_01,CameraPos110111_01_003)
	Camera002 = SetTemplate("Actor002",35,CharaPos110111_01_005,"content_motion3d_advarea_common_adv_templatecontroller","Chr_512_01_StdController","to Std_Loop",CameraAssetBundleName110111_01,CameraPos110111_01_005)
	InitializeTemplateRandomCamera110111_01()
	InitializeTemplate110111_01()
-- ▼直接出力
Hide(Actor002)
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(110111)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101020","001","101020001","content_animationpack__common","FacialPack","Actor002")
	template1()
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

-- ▼直接出力
PlayPartVoiceDirect("ノワール","0034")
-- ▲直接出力

	--★★ノワール★★:ブレイズ先生、なんかいつもと様子が違ったな<br>いつもはもっと飄々としてるっていうか…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101066_07020005")

-- ▼直接出力
CloseTalkWindow()
DontChangeRandomCamera(true) -- ランダムカメラを一時的にOFF
EntryWalk(Actor002,Camera002,EntryData110111_01_05,CameraAssetBundleName110111_01,CameraPos110111_01_105)
DontChangeRandomCamera(false) -- ランダムカメラを再びON
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Talk")
-- ▼直接出力
PlayPartVoiceDirect("マーリン","0004")
-- ▲直接出力

	--★★マーリン★★:ノワール様、少々よろしいでしょうか
	Talk(Actor002,"CHRNAME_MERLIN","speech","L","CO_101066_07020007")

-- ▼直接出力
setup_small_camera_start(RndCamera001)
-- ▲直接出力
-- ▼直接出力
voice_play("VO_101009_sp_0011_1")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:マーリンさん。なんでしょう？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101066_07020008")

	change_face(Actor002,"Smile")

	--★★マーリン★★:最近、あなたは先生と仲がよろしいようですね
	Talk(Actor002,"CHRNAME_MERLIN","speech","L","CO_101066_07020009")

	change_face(Actor001,"Sad")

	--★★ノワール★★:仲がいい、といっていいんですかね？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101066_07020010")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoiceDirect("マーリン","0008")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★マーリン★★:ええ、もちろん<br>最近の先生は本当に活き活きとされてますから
	Talk(Actor002,"CHRNAME_MERLIN","speech","L","CO_101066_07020011")

-- ▼直接出力
setup_small_camera_end(RndCamera001)
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★マーリン★★:…ただ、ここ最近の先生は、今まで以上に<br>根を詰めて研究をしているようなのです
	Talk(Actor002,"CHRNAME_MERLIN","speech","L","CO_101066_07020012")

-- ▼直接出力
setup_small_camera_end(RndCamera001)
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Worry")
-- ▼直接出力
PlayPartVoiceDirect("ノワール","0009")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:そう言われてみれば…<br>自慢の髭の手入れも全然してなかったな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101066_07020013")

	PlayAction(Actor002,"to  Std_Sad02")
-- ▼直接出力
PlayPartVoiceDirect("マーリン","0034")
-- ▲直接出力

	--★★マーリン★★:ええ。心配で様子を窺いたくても<br>部屋に立ち入りを禁じる魔法までかけていて…
	Talk(Actor002,"CHRNAME_MERLIN","speech","L","CO_101066_07020014")

	PlayAction(Actor001,"to  Std_Talk")

	--★★ノワール★★:立ち入りを禁じる魔法？<br>俺、ふつうに入れましたけど…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101066_07020015")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoiceDirect("マーリン","0009")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★マーリン★★:…そうですか。それはきっと、<br>あなたが研究の協力者だからでしょう
	Talk(Actor002,"CHRNAME_MERLIN","speech","L","CO_101066_07020016")

-- ▼直接出力
setup_small_camera_start(RndCamera005)
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Talk")
-- ▼直接出力
PlayPartVoiceDirect("マーリン","0042")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★マーリン★★:ノワール様、どうか先生の様子を<br>見てきてはいただけないでしょうか
	Talk(Actor002,"CHRNAME_MERLIN","speech","L","CO_101066_07020017")


	--★★マーリン★★:学園の外に構えた自宅にも帰っていないようで<br>どうしても気になってしまって
	Talk(Actor002,"CHRNAME_MERLIN","speech","L","CO_101066_07020018")

	PlayAction(Actor002,"to  Std_No")
-- ▼直接出力
PlayPartVoiceDirect("マーリン","0025")
-- ▲直接出力

	--★★マーリン★★:…まぁ、あの家はあの家で心配ではあるのですが
	Talk(Actor002,"CHRNAME_MERLIN","speech","L","CO_101066_07020019")

	PlayAction(Actor001,"to  Std_Talk")
	change_face(Actor001,"Surprise")

	--★★ノワール★★:どういうことですか？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101066_07020020")

-- ▼直接出力
setup_small_camera_end(RndCamera005)
-- ▲直接出力
	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoiceDirect("マーリン","0007")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★マーリン★★:先生は学園の外の庵にひとりで暮らしています<br>バルバロイを観察するにはいちばんいい場所だと
	Talk(Actor002,"CHRNAME_MERLIN","speech","L","CO_101066_07020021")

	change_face(Actor002,"Sad")

	--★★マーリン★★:キラーズ因子の強い人間を狙うバルバロイは<br>学園の生徒たちに引き寄せられてきますから
	Talk(Actor002,"CHRNAME_MERLIN","speech","L","CO_101066_07020022")

	PlayAction(Actor001,"to  Std_Worry")
-- ▼直接出力
PlayPartVoiceDirect("ノワール","0046")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:ブレイズ先生らしいな<br>でも、あれだけ強ければ心配なんて…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101066_07020023")

	play_head_motion(Actor002, "No", 0.3, 1.0, false)

	--★★マーリン★★:…師匠の魔法では<br>バルバロイを倒すことはできないのです
	Talk(Actor002,"CHRNAME_MERLIN","speech","L","CO_101066_07020024")


	--★★マーリン★★:バルバロイを倒せるのは、<br>キラーズ因子をもつ者だけですから
	Talk(Actor002,"CHRNAME_MERLIN","speech","L","CO_101066_07020025")

	change_face(Actor001,"Surprise")

	--★★ノワール★★:え…それって
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101066_07020026")

-- ▼直接出力
setup_small_camera_start(RndCamera001)
-- ▲直接出力
	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)

	--★★マーリン★★:詳しくは、先生の口から直接<br>お聞きになるのがよいかと思います。ただ…
	Talk(Actor002,"CHRNAME_MERLIN","speech","L","CO_101066_07020027")


	--★★マーリン★★:先生が魔法使いを引退したのは…<br>バルバロイが急激に増え始めてからです
	Talk(Actor002,"CHRNAME_MERLIN","speech","L","CO_101066_07020028")

	change_face(Actor001,"Normal")

	--★★ノワール★★:………
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101066_07020029")

-- ▼直接出力
reserve_next_script("1章/コミュ/x0401_ブレイズ_ランクアップ7_4")
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
	load_area_scene_preload(110111)
	InitializeCharacter_3D_Preload("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101020","001","101020001","content_animationpack__common","FacialPack","Actor002")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110111_01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
