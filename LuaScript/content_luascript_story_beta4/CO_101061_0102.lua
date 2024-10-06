-- このluaスクリプトは、CO_101061_0102.csv の ADV シートから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110111_02","110111_02_h")
Include("content_adv_advsmall_110111_02","Template110111_02_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos110111_02_001,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName110111_02,CameraPos110111_02_001)
	Camera002 = SetTemplate("Actor002",nil,CharaPos110111_02_002,"content_motion3d_advarea_common_adv_templatecontroller","Npc_011_01_StdController","to Std_Loop",CameraAssetBundleName110111_02,CameraPos110111_02_002)
	Camera003 = SetTemplate("Actor003",nil,CharaPos110111_02_004,"content_motion3d_advarea_common_adv_templatecontroller","Npc_501_01_StdController","to Std_Loop",CameraAssetBundleName110111_02,CameraPos110111_02_004)
	Camera004 = SetTemplate("Actor004",nil,CharaPos110111_02_007,"content_motion3d_advarea_common_adv_templatecontroller","Npc_501_01_StdController","to Std_Loop",CameraAssetBundleName110111_02,CameraPos110111_02_007)
	Camera005 = SetTemplate("Actor005",nil,CharaPos110111_02_008,"content_motion3d_advarea_common_adv_templatecontroller","Npc_001_01_StdController","to Std_Loop",CameraAssetBundleName110111_02,CameraPos110111_02_008)
	InitializeTemplateRandomCamera110111_02()
	InitializeTemplate110111_02()
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(110111)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101061","001","101061001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("401006","001","401006001","content_animationpack__common","FacialPack","Actor003")
	Actor004 = InitializeCharacter_3D("401010","001","401010001","content_animationpack__common","FacialPack","Actor004")
	Actor005 = InitializeCharacter_3D("401009","001","401009001","content_animationpack__common","FacialPack","Actor005")
	template1()
-- ▼直接出力
PlayActionDirect(Actor003,"to  Std_Talk")
PlayActionDirect(Actor004,"to  Std_Yes")
PlayActionDirect(Actor005,"to  Std_Talk")
-- ▲直接出力
-- ▼直接出力
keep_ik_lookat(Actor001,Actor002,"J_Head")
keep_ik_lookat(Actor002,Actor001,"J_Head")
-- ▲直接出力
-- ▼直接出力
lookat_weight(Actor001,0.7,0.05,0.5,0.2)
-- ▲直接出力
-- ▼直接出力
lookat_weight(Actor002,0.7,0.05,0.5,0.2)
-- ▲直接出力
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")

end

function Play()
	StartPlay()

	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ノワール", "悩む")
-- ▲直接出力

	--★★ノワール★★:そろそろ話してくれよ<br>俺になんの用事なんだ？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101061_01020002")

-- ▼直接出力
setup_small_camera_start()
PlayActionDirect(Actor004,"to  Std_Talk")
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ラロゥ", "悩む")
-- ▲直接出力

	--★★ラロゥ★★:あれについて<br>ちょっと教えてほしいんだよね
	Talk(Actor002,"CHRNAME_LAROU","speech","L","CO_101061_01020004")


	--★★ノワール★★:まさかとは思うけど<br>学園の生徒たちに悪さするつもりじゃないよな？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101061_01020005")

	play_head_motion(Actor002, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ラロゥ", "怒り")
-- ▲直接出力
	change_face(Actor002,"Surprise")

	--★★ラロゥ★★:はあ？<br>そんなわけないでしょ
	Talk(Actor002,"CHRNAME_LAROU","speech","L","CO_101061_01020006")

	change_face(Actor002,"Normal")

	--★★ラロゥ★★:もしそうだとしても<br>円卓の騎士様に相談なんてしないよ
	Talk(Actor002,"CHRNAME_LAROU","speech","L","CO_101061_01020007")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Talk")

	--★★ラロゥ★★:この街をうろついてると<br>イヤでも学園の生徒が目に入って来るじゃない？
	Talk(Actor002,"CHRNAME_LAROU","speech","L","CO_101061_01020008")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ラロゥ", "肯定")
-- ▲直接出力

	--★★ラロゥ★★:通ってる連中、みんな楽しそうだよね<br>オレとは違う世界の住民みたいだ
	Talk(Actor002,"CHRNAME_LAROU","speech","L","CO_101061_01020009")


	--★★ラロゥ★★:それであの学園でなにをやってるのか<br>だんだん気になり始めてきてさ
	Talk(Actor002,"CHRNAME_LAROU","speech","L","CO_101061_01020010")

	PlayAction(Actor002,"to  Std_Talk")

	--★★ラロゥ★★:あそこに通う唯一の知り合いであるアンタに<br>聞きたいってわけ
	Talk(Actor002,"CHRNAME_LAROU","speech","L","CO_101061_01020011")

	open_select_window_tag(Actor001,"Normal","CO_101061_01020013","CO_101061_01020014","CO_101061_01020015")
	if is_select(1) then
		goto Block1_1
	elseif is_select(2) then
		goto Block1_2
	elseif is_select(3) then
		goto Block1_3
	end

::Block1_1::
	CloseTalkWindow()
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "肯定")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:学園は勉強をする場所だよ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101061_01020017")

	play_head_motion(Actor002, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ラロゥ", "苦しみ")
-- ▲直接出力
	change_face(Actor002,"Anger")

	--★★ラロゥ★★:バカにしないでくれる？<br>そんなこと知ってるよ
	Talk(Actor002,"CHRNAME_LAROU","speech","L","CO_101061_01020018")

	change_face(Actor002,"Normal")

	--★★ラロゥ★★:でもさ、勉強なんて本読めばいいじゃん<br>他にもっと秘密があるんじゃないの
	Talk(Actor002,"CHRNAME_LAROU","speech","L","CO_101061_01020019")

	PlayAction(Actor001,"to  Std_Worry")
-- ▼直接出力
PlayPartVoice("ノワール", "照れ")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:秘密ってほどのことはないけど…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101061_01020020")

	goto Block1end

::Block1_2::
	CloseTalkWindow()
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "肯定")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:学園は友達を作る場所だよ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101061_01020022")

	change_face(Actor002,"Surprise")

	--★★ラロゥ★★:そんなの<br>その辺の路地でもできるじゃん
	Talk(Actor002,"CHRNAME_LAROU","speech","L","CO_101061_01020023")

	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ノワール", "笑い")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★ノワール★★:学園にはいろんなところから人が来る<br>新しい出会いもあったりするんだ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101061_01020024")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ラロゥ", "肯定2")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★ラロゥ★★:ふーん。まあ、一理あるかも<br>路地だと地元の奴らばっかだし
	Talk(Actor002,"CHRNAME_LAROU","speech","L","CO_101061_01020025")

	goto Block1end

::Block1_3::
	CloseTalkWindow()
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "肯定")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:学園はサークル活動を頑張る場所だよ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101061_01020027")

-- ▼直接出力
PlayPartVoice("ラロゥ", "肯定2")
-- ▲直接出力
	change_face(Actor002,"Surprise")

	--★★ラロゥ★★:サークル活動ってなに？
	Talk(Actor002,"CHRNAME_LAROU","speech","L","CO_101061_01020028")

	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ノワール", "悩む")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:スポーツとか音楽とか<br>そういうのを好きな連中の集まりっていうのかな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101061_01020029")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ラロゥ", "納得")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★ラロゥ★★:へえ、そんなのもあるんだ<br>なかなか楽しそうだね
	Talk(Actor002,"CHRNAME_LAROU","speech","L","CO_101061_01020030")

	goto Block1end

::Block1end::
-- ▼直接出力
PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:まあ、でも、実際それくらいだよ<br>別に大したところじゃない
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101061_01020032")

	change_face(Actor002,"Normal")

	--★★ラロゥ★★:それくらい？<br>ホントかな
	Talk(Actor002,"CHRNAME_LAROU","speech","L","CO_101061_01020033")

	play_head_motion(Actor001, "No", 0.3, 1.0, false)

	--★★ノワール★★:ここでお前に嘘ついてどうするんだよ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101061_01020034")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ラロゥ", "挨拶")
-- ▲直接出力

	--★★ラロゥ★★:だったら<br>今度、学園の中を案内してよ
	Talk(Actor002,"CHRNAME_LAROU","speech","L","CO_101061_01020035")


	--★★ラロゥ★★:ホントかどうか確かめたいからさ
	Talk(Actor002,"CHRNAME_LAROU","speech","L","CO_101061_01020036")

-- ▼直接出力
PlayPartVoice("ノワール", "悩む")
-- ▲直接出力

	--★★ノワール★★:なにか企んでるんじゃないだろうな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101061_01020038")

	play_head_motion(Actor002, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ラロゥ", "怒り")
-- ▲直接出力
	change_face(Actor002,"Anger")

	--★★ラロゥ★★:いたいけな子供を疑うのはやめてくれる？
	Talk(Actor002,"CHRNAME_LAROU","speech","L","CO_101061_01020039")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
	change_face(Actor002,"Normal")

	--★★ラロゥ★★:いたってフツーに、純粋に<br>学園に興味があるだけだよ
	Talk(Actor002,"CHRNAME_LAROU","speech","L","CO_101061_01020040")

	PlayAction(Actor001,"to  Std_Worry")
	change_face(Actor001,"Sad")

	--★★ノワール★★:いたいけな子供ねえ…？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101061_01020041")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Talk")
	change_face(Actor001,"Normal")

	--★★ノワール★★:でも、案内してくれとは言うけど<br>学園の敷地内に入るだけなら誰でもできるぞ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101061_01020042")

-- ▼直接出力
PlayPartVoice("ラロゥ", "肯定2")
-- ▲直接出力
	change_face(Actor002,"Surprise")

	--★★ラロゥ★★:へえ、そうなの
	Talk(Actor002,"CHRNAME_LAROU","speech","L","CO_101061_01020043")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力

	--★★ノワール★★:もちろん、監視の目は付くけどな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101061_01020044")

-- ▼直接出力
PlayPartVoice("ラロゥ", "肯定")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★ラロゥ★★:だろうね
	Talk(Actor002,"CHRNAME_LAROU","speech","L","CO_101061_01020045")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
	change_face(Actor002,"Smile")

	--★★ラロゥ★★:だとすると余計に<br>アンタに付き添ってもらったほうがいいね
	Talk(Actor002,"CHRNAME_LAROU","speech","L","CO_101061_01020046")

	change_face(Actor002,"Normal")

	--★★ラロゥ★★:オレが怪しいヤツじゃないって<br>証明してもらうためにさ
	Talk(Actor002,"CHRNAME_LAROU","speech","L","CO_101061_01020047")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "悩む")
-- ▲直接出力

	--★★ノワール★★:…ヒマなときなら、いいけど
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101061_01020048")

-- ▼直接出力
PlayPartVoice("ラロゥ", "笑い")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★ラロゥ★★:決まりだね
	Talk(Actor002,"CHRNAME_LAROU","speech","L","CO_101061_01020049")

	PlayAction(Actor002,"to Greet_one")

	--★★ラロゥ★★:オレはふだん街中でブラブラしてるからさ<br>時間あるときに声かけてよ
	Talk(Actor002,"CHRNAME_LAROU","speech","L","CO_101061_01020050")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
-- ▼直接出力
local trustParam = set_communication_acquired("ラロゥ_コミュランク", "ラロゥ_親密度")
-- ▲直接出力
-- ▼直接出力
open_trust_release(Actor002, trustParam)
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
	InitializeCharacter_3D_Preload("101061","001","101061001","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("401006","001","401006001","content_animationpack__common","FacialPack","Actor003")
	InitializeCharacter_3D_Preload("401010","001","401010001","content_animationpack__common","FacialPack","Actor004")
	InitializeCharacter_3D_Preload("401009","001","401009001","content_animationpack__common","FacialPack","Actor005")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110111_02)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
