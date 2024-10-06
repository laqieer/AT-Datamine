-- このluaスクリプトは、MA_01C201_16.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110101_01","110101_01_h")
Include("content_adv_advsmall_110101_01","Template110101_01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos110101_01_002,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName110101_01,CameraPos110101_01_002)
	Camera002 = SetTemplate("Actor002",323,CharaPos110101_01_003,"content_motion3d_advarea_common_adv_templatecontroller","Chr_512_01_StdController","to Std_Loop",CameraAssetBundleName110101_01,CameraPos110101_01_003)
	Camera003 = SetTemplate("Actor003",nil,CharaPos110101_01_005,"content_motion3d_advarea_common_adv_templatecontroller","Chr_006_01_StdController","to Std_Loop",CameraAssetBundleName110101_01,CameraPos110101_01_005)
	Camera004 = SetTemplate("Actor004",nil,CharaPos110101_01_001,"content_motion3d_advarea_common_adv_templatecontroller","Npc_008_01_StdController","to Std_Loop",CameraAssetBundleName110101_01,CameraPos110101_01_001)
	Camera005 = SetTemplate("Actor005",nil,CharaPos110101_01_006,"content_motion3d_advarea_common_adv_templatecontroller","Chr_020_01_StdController","to Std_Loop",CameraAssetBundleName110101_01,CameraPos110101_01_006)
	InitializeTemplateRandomCamera110101_01()
	InitializeTemplate110101_01()
-- ▼直接出力
set_enable_auto_lookat_all(alse)
-- ▲直接出力
-- ▼直接出力
lookat_weight(Actor002,0.5,0.1,0.85,0.2)
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(115104)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101020","001","101020001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("101022","001","101022001","content_animationpack__common","FacialPack","Actor003")
	Actor004 = InitializeCharacter_3D("101040","001","101040001","content_animationpack__common","FacialPack","Actor004")
	Actor005 = InitializeCharacter_3D("101051","001","101051001","content_animationpack__common","FacialPack","Actor005")
	template1()
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor003,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor004,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

-- ▼直接出力
 --PlayPartVoice("ケイ", "挨拶")
-- ▲直接出力

	--★★ケイ★★:ギネヴィアの容態は
	Talk(Actor004,"CHRNAME_KAY","speech","L","MA_01C201_160002")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("マーリン", "肯定")
-- ▲直接出力

	--★★マーリン★★:命に別状はないそうです<br>…かなり衰弱している様子ですが
	Talk(Actor002,"CHRNAME_MERLIN","speech","L","MA_01C201_160003")

-- ▼直接出力
 --PlayPartVoice("ルーシャス", "肯定")
-- ▲直接出力

	--★★ルーシャス★★:無理もあるまい<br>ひとりだったのであろう？
	Talk(Actor005,"CHRNAME_LUCIUS","speech","L","MA_01C201_160004")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor003,"to  Std_Worry")
-- ▼直接出力
 --PlayPartVoice("モルドレッド", "挨拶")
-- ▲直接出力

	--★★モルドレッド★★:キラーズはどうしたよ<br>アーサーのヤロウにやられちまったか？
	Talk(Actor003,"CHRNAME_MORDRED","speech","L","MA_01C201_160005")

	PlayAction(Actor001,"to  Std_Surp")
-- ▼直接出力
 --PlayPartVoice("ノワール", "怒り")
-- ▲直接出力
	change_face(Actor001,"Anger")

	--★★ノワール★★:モルドレッド…！
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01C201_160006")

	play_head_motion(Actor003, "No", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("モルドレッド", "肯定2")
-- ▲直接出力

	--★★モルドレッド★★:無い話じゃねえだろ<br>
	Talk(Actor003,"CHRNAME_MORDRED","speech","L","MA_01C201_160007")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	open_select_window_tag(Actor001,"Normal","MA_01C201_160008","MA_01C201_160009")
	if is_select(1) then
		goto Block1_1
	elseif is_select(2) then
		goto Block1_2
	end

::Block1_1::
	CloseTalkWindow()
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
	change_face(Actor001,"Normal")

	--★★ノワール★★:ギネマウアさんは強い人だ<br>きっと大丈夫
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01C201_160011")

-- ▼直接出力
 --PlayPartVoice("モルドレッド", "驚き")
-- ▲直接出力
	change_face(Actor003,"Normal")

	--★★モルドレッド★★:なにを根拠にそう言えんだよ
	Talk(Actor003,"CHRNAME_MORDRED","speech","L","MA_01C201_160012")

-- ▼直接出力
 --PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:ギネマウアさんは<br>ギネヴィアをひとりぼっちにしない
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01C201_160013")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
	change_face(Actor001,"Normal")

	--★★ノワール★★:…絶対に
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01C201_160014")

	change_face(Actor003,"Sad")

	--★★モルドレッド★★:へッ、そうかよ
	Talk(Actor003,"CHRNAME_MORDRED","speech","L","MA_01C201_160015")

	goto Block1end

::Block1_2::
	CloseTalkWindow()
	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
 --PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:どれだけ甘ちゃんだと言われようとも<br>俺はアーサーを信じたい
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01C201_160017")

	change_face(Actor001,"Normal")

	--★★ノワール★★:だから…きっとギネマウアさんは無事だ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01C201_160018")

	play_head_motion(Actor004, "Nod", 0.3, 1.0, false)
-- ▼直接出力
set_enable_auto_lookat(Actor002,false)
 --PlayPartVoice("ケイ", "肯定")
-- ▲直接出力
	change_face(Actor004,"Normal")

	--★★ケイ★★:そうだな<br>私もそうであると信じたい
	Talk(Actor004,"CHRNAME_KAY","speech","L","MA_01C201_160019")

	goto Block1end

::Block1end::
-- ▼直接出力
wait_time(0.5)
setup_small_camera_start()
-- ▲直接出力
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("ノワール", "肯定")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:…とにかく、<br>今はギネヴィアの回復を待つしかない
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01C201_160021")

	change_face(Actor001,"Normal")

	--★★ノワール★★:ちゃんと話をするって、言ってたんだ<br>だから<br>?
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01C201_160022")

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
	InitializeCharacter_3D_Preload("101020","001","101020001","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("101022","001","101022001","content_animationpack__common","FacialPack","Actor003")
	InitializeCharacter_3D_Preload("101040","001","101040001","content_animationpack__common","FacialPack","Actor004")
	InitializeCharacter_3D_Preload("101051","001","101051001","content_animationpack__common","FacialPack","Actor005")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor003,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor004,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110101_01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
