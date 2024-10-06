-- このluaスクリプトは、MA_01C201_07.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110101_01","110101_01_h")
Include("content_adv_advsmall_110101_01","Template110101_01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos110101_01_002,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName110101_01,CameraPos110101_01_002)
	Camera002 = SetTemplate("Actor002",83,CharaPos110101_01_006,"content_motion3d_advarea_common_adv_templatecontroller","Chr_006_01_StdController","to Std_Loop",CameraAssetBundleName110101_01,CameraPos110101_01_006)
	InitializeTemplateRandomCamera110101_01()
	InitializeTemplate110101_01()
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(115104)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101022","001","101022001","content_animationpack__common","FacialPack","Actor002")
	template1()
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

-- ▼直接出力
 --PlayPartVoice("モルドレッド", "挨拶")
-- ▲直接出力

	--★★モルドレッド★★:なんでアーサーのヤロウは<br>聖杯を壊したと思う
	Talk(Actor002,"CHRNAME_MORDRED","speech","L","MA_01C201_070002")


	--★★ノワール★★:それは…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01C201_070003")

	open_select_window_tag(Actor001,"Normal","MA_01C201_070004","MA_01C201_070005")
	if is_select(1) then
		goto Block1_1
	elseif is_select(2) then
		goto Block1_2
	end

::Block1_1::
	CloseTalkWindow()
-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("ノワール", "悩む")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:恐れているからかな<br>聖杯の力を
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01C201_070007")

-- ▼直接出力
 --PlayPartVoice("モルドレッド", "肯定")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★モルドレッド★★:ま、そう考えるのが<br>わかりやすくはあるよなァ
	Talk(Actor002,"CHRNAME_MORDRED","speech","L","MA_01C201_070008")

	play_head_motion(Actor002, "No", 0.3, 1.0, false)
	change_face(Actor002,"Normal")

	--★★モルドレッド★★:けど、どうもしっくりこねぇ
	Talk(Actor002,"CHRNAME_MORDRED","speech","L","MA_01C201_070009")

	goto Block1end

::Block1_2::
	CloseTalkWindow()
-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Worry")
-- ▼直接出力
 --PlayPartVoice("ノワール", "悩む")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:嫌っているから…とか？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01C201_070011")

-- ▼直接出力
 --PlayPartVoice("モルドレッド", "驚き")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★モルドレッド★★:願いを叶えてくれるってのに<br>なんで嫌う必要があんだよ
	Talk(Actor002,"CHRNAME_MORDRED","speech","L","MA_01C201_070012")

	play_head_motion(Actor002, "No", 0.3, 1.0, false)
	change_face(Actor002,"Normal")

	--★★モルドレッド★★:伝説が憎いかなんだか知らねえが<br>聞き分けのねえガキかっつーんだ
	Talk(Actor002,"CHRNAME_MORDRED","speech","L","MA_01C201_070013")

	goto Block1end

::Block1end::
	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
 --PlayPartVoice("ノワール", "肯定")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:アーサーは強い。けどそんなアーサーですら<br>聖杯の力に抗うのは難しいのかもしれない
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01C201_070015")

	change_face(Actor001,"Sad")

	--★★ノワール★★:どんなに伝説を憎んでいても<br>聖杯があれば手を伸ばしてしまう。だから…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01C201_070016")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	play_head_motion(Actor002, "No", 0.3, 1.0, false)
	change_face(Actor002,"Sad")

	--★★モルドレッド★★:だからその前に壊した、ってことかぁ？<br>よくわかんねぇな
	Talk(Actor002,"CHRNAME_MORDRED","speech","L","MA_01C201_070017")

-- ▼直接出力
 --PlayPartVoice("モルドレッド", "挨拶")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★モルドレッド★★:そもそもアーサーのヤロウは<br>なんでそこまで伝説を憎むんだ？
	Talk(Actor002,"CHRNAME_MORDRED","speech","L","MA_01C201_070018")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Worry")

	--★★モルドレッド★★:てめえで大事にしてきたモン全部<br>ぶっ壊させるほどの憎しみってなんだ？
	Talk(Actor002,"CHRNAME_MORDRED","speech","L","MA_01C201_070019")


	--★★ノワール★★:それは…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01C201_070020")

-- ▼直接出力
 --PlayPartVoice("モルドレッド", "笑い")
-- ▲直接出力

	--★★モルドレッド★★:…ま、考えても無駄か<br>アイツはもうイカれてやがる
	Talk(Actor002,"CHRNAME_MORDRED","speech","L","MA_01C201_070021")

	play_head_motion(Actor002, "No", 0.3, 1.0, false)

	--★★モルドレッド★★:あのヤロウがなに考えてるかなんて<br>いまや誰もわかんねえだろ
	Talk(Actor002,"CHRNAME_MORDRED","speech","L","MA_01C201_070022")

-- ▼直接出力
 --PlayPartVoice("ノワール", "落胆")
-- ▲直接出力

	--★★ノワール★★:………
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01C201_070023")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力

	--★★モルドレッド★★:俺はずっとアイツに勝ちたかった<br>だが今はもう勝つ意味もねえ
	Talk(Actor002,"CHRNAME_MORDRED","speech","L","MA_01C201_070024")

	PlayAction(Actor002,"to  Std_Angry")
	change_face(Actor002,"Anger")

	--★★モルドレッド★★:ただ倒さなきゃならねえ相手ってだけだ<br>?
	Talk(Actor002,"CHRNAME_MORDRED","speech","L","MA_01C201_070025")

	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	InitializeLoad_Preload()
	load_area_scene_preload(115104)
	InitializeCharacter_3D_Preload("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101022","001","101022001","content_animationpack__common","FacialPack","Actor002")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110101_01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
