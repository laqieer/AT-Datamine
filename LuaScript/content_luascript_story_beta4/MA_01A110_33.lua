-- このluaスクリプトは、MA_01A110_33.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110011_07","110011_07_h")
Include("content_adv_advsmall_110011_07","Template110011_07_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos110011_07_006,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName110011_07,CameraPos110011_07_006)
	Camera002 = SetTemplate("Actor002",nil,CharaPos110011_07_003,"content_motion3d_advarea_common_adv_templatecontroller","Chr_502_01_StdController","to Std_Loop",CameraAssetBundleName110011_07,CameraPos110011_07_003)
	Camera003 = SetTemplate("Actor003",nil,CharaPos110011_07_004,"content_motion3d_advarea_common_adv_templatecontroller","Chr_501_01_StdController","to Std_Loop",CameraAssetBundleName110011_07,CameraPos110011_07_004)
	Camera004 = SetTemplate("Actor004",nil,CharaPos110011_07_001,"content_motion3d_advarea_common_adv_templatecontroller","Com_f_SitController","to Sit01_Loop",CameraAssetBundleName110011_07,CameraPos110011_07_001)
	Camera005 = SetTemplate("Actor005",nil,CharaPos110011_07_005,"content_motion3d_advarea_common_adv_templatecontroller","Chr_520_01_StdController","to Std_Loop",CameraAssetBundleName110011_07,CameraPos110011_07_005)
	Camera006 = SetTemplate("Actor006",nil,CharaPos110011_07_010,"content_motion3d_advarea_common_adv_templatecontroller","Chr_503_01_StdController","to Std_Loop",CameraAssetBundleName110011_07,CameraPos110011_07_010)
	InitializeTemplateRandomCamera110011_07()
	InitializeTemplate110011_07()
-- ▼直接出力
set_enable_auto_lookat_all(false)
turn_lookat(Actor001,Actor004,0)
-- ▲直接出力
-- ▼直接出力
lookat_weight(Actor004,0.5,0.1,0.85,0.2)
keep_ik_lookat(Actor004,Actor002,"J_Head")
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(115020)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101011","001","101011001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("101012","001","101012001","content_animationpack__common","FacialPack","Actor003")
	Actor004 = InitializeCharacter_3D("101017","001","101017001","content_animationpack__common","FacialPack","Actor004")
	Actor005 = InitializeCharacter_3D("101030","001","101030001","content_animationpack__common","FacialPack","Actor005")
	Actor006 = InitializeCharacter_3D("101016","001","101016001","content_animationpack__common","FacialPack","Actor006")
	template1()
	load_head_animation(Actor006,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor004,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor003,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

-- ▼直接出力
 --PlayPartVoice("マルディサント", "肯定2")
-- ▲直接出力

	--★★マルディサント★★:あんま忖度しねえで言やあよぉ──
	Talk(Actor004,"CHRNAME_MALADISANT","speech","L","MA_01A110_330002")

	PlayAction(Actor005,"to  Std_Appl")
-- ▼直接出力
 --PlayPartVoice("エレイン", "照れ")
-- ▲直接出力
	change_face(Actor005,"Shy")

	--★★エレイン★★:ギネヴィア様…<br>お芝居、上手です…すごく、すごく
	Talk(Actor005,"CHRNAME_ELAINE","speech","L","MA_01A110_330004")

	play_head_motion(Actor006, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("ギネマウア", "笑い")
-- ▲直接出力
	change_face(Actor006,"Smile")

	--★★ギネマウア★★:ギネヴィア様、さすがです
	Talk(Actor006,"CHRNAME_GWENHWYMAWR","speech","L","MA_01A110_330005")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Worry")
-- ▼直接出力
 --PlayPartVoice("ギネヴィア", "照れ")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★ギネヴィア★★:そ、そうお？そうお？？
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","MA_01A110_330007")

-- ▼直接出力
 --PlayPartVoice("マルディサント", "肯定")
-- ▲直接出力

	--★★マルディサント★★:演技はウマいが、ウソくせえな
	Talk(Actor004,"CHRNAME_MALADISANT","speech","L","MA_01A110_330008")

	PlayAction(Actor002,"to  Std_Surp")
-- ▼直接出力
 --PlayPartVoice("ギネヴィア", "驚き")
-- ▲直接出力
	change_face(Actor002,"Surprise")

	--★★ギネヴィア★★:グサッ
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","MA_01A110_330009")

-- ▼直接出力
 --PlayPartVoice("マルディサント", "悩む")
-- ▲直接出力

	--★★マルディサント★★:なんていうか<br>うわべをなぞってるっつーか
	Talk(Actor004,"CHRNAME_MALADISANT","speech","L","MA_01A110_330010")

	PlayAction(Actor002,"to  Std_Sad01")
-- ▼直接出力
 --PlayPartVoice("ギネヴィア", "苦しみ")
-- ▲直接出力

	--★★ギネヴィア★★:グサグサッ
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","MA_01A110_330011")

	play_head_motion(Actor004, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("マルディサント", "納得")
-- ▲直接出力
	change_face(Actor004,"Surprise")

	--★★マルディサント★★:しゃーねえよな<br>王妃の役をイヤイヤ演じ続けてたんだ
	Talk(Actor004,"CHRNAME_MALADISANT","speech","L","MA_01A110_330012")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	change_face(Actor004,"Normal")

	--★★マルディサント★★:自分のリアルを<br>役柄に持ち込んだことがねえんだろ
	Talk(Actor004,"CHRNAME_MALADISANT","speech","L","MA_01A110_330013")

	PlayAction(Actor002,"to HoldHead")
-- ▼直接出力
 --PlayPartVoice("ギネヴィア", "悩む")
-- ▲直接出力
	change_face(Actor002,"Pain")

	--★★ギネヴィア★★:ウッ、ウウウッ…！？
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","MA_01A110_330015")

-- ▼直接出力
keep_delay_ik_lookat(Actor003,Actor004,"J_Head",1.0)
-- ▲直接出力
	PlayAction(Actor003,"to  Std_Talk")
-- ▼直接出力
 --PlayPartVoice("ディナタン", "否定")
-- ▲直接出力
	change_face(Actor003,"Sad")

	--★★ディナタン★★:ま、マァル、いきなり厳しすぎ…！<br>というかギネヴィア様、じょうずだったよ…！？
	Talk(Actor003,"CHRNAME_DINATAN","speech","L","MA_01A110_330016")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
-- ▼直接出力
keep_delay_ik_lookat(Actor003,Actor002,"J_Head",1.0)
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Angry")
-- ▼直接出力
SkipDefaultMotion(Actor002)
 --PlayPartVoice("ギネヴィア", "悲しみ")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★ギネヴィア★★:こ、こんな言う？こんなに言うぅ…？<br>パワハラ？演出にかこつけたパワハラじゃない？
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","MA_01A110_330018")

	play_head_motion(Actor004, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("マルディサント", "肯定2")
-- ▲直接出力

	--★★マルディサント★★:「おじょうず」なだけでイイのか？
	Talk(Actor004,"CHRNAME_MALADISANT","speech","L","MA_01A110_330019")

-- ▼直接出力
PlayActionDirect(Actor002,"to Std_Loop")
-- ▲直接出力
-- ▼直接出力
 --PlayPartVoice("ギネヴィア", "驚き")
-- ▲直接出力
	change_face(Actor002,"Surprise")

	--★★ギネヴィア★★:え…？
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","MA_01A110_330020")


	--★★マルディサント★★:なんで学園祭なんておめでてーこと<br>アタシらでやんだっけ？
	Talk(Actor004,"CHRNAME_MALADISANT","speech","L","MA_01A110_330021")

	change_face(Actor002,"Sad")

	--★★ギネヴィア★★:………それは
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","MA_01A110_330022")

	play_head_motion(Actor004, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("マルディサント", "気合い")
-- ▲直接出力
	change_face(Actor004,"Anger")

	--★★マルディサント★★:演技はアクション！なにをすべきか考えろ！<br>コトバだけじゃねえ、アンタの行動で示すんだ！
	Talk(Actor004,"CHRNAME_MALADISANT","speech","L","MA_01A110_330023")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	change_face(Actor002,"Surprise")

	--★★ギネヴィア★★:演技は、アクション…
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","MA_01A110_330025")

	play_head_motion(Actor004, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("マルディサント", "激怒")
-- ▲直接出力

	--★★マルディサント★★:アンタのリアルを見つめなおせ！<br>舞台から逃げんな！アンタが舞台に乗るんだよ！
	Talk(Actor004,"CHRNAME_MALADISANT","speech","L","MA_01A110_330027")

	change_face(Actor002,"Normal")

	--★★ギネヴィア★★:わたしの、リアル…！
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","MA_01A110_330028")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor003,"to  Std_No")
-- ▼直接出力
 --PlayPartVoice("ディナタン", "落胆")
-- ▲直接出力

	--★★ディナタン★★:マァルが暑苦しい…<br>そしてギネヴィア様が感化されつつある…
	Talk(Actor003,"CHRNAME_DINATAN","speech","L","MA_01A110_330029")

-- ▼直接出力
 --PlayPartVoice("マルディサント", "挨拶")
-- ▲直接出力

	--★★マルディサント★★:木！いるか！木！<br>出てこい！木を継ぐ者よ！
	Talk(Actor004,"CHRNAME_MALADISANT","speech","L","MA_01A110_330030")

-- ▼直接出力
set_enable_auto_lookat(Actor004,true)
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Surp")
-- ▼直接出力
 --PlayPartVoice("ノワール", "驚き")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:お、俺か？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01A110_330031")

-- ▼直接出力
set_enable_auto_lookat(Actor004,false)
-- ▲直接出力
-- ▼直接出力
 --PlayPartVoice("マルディサント", "肯定")
-- ▲直接出力
	change_face(Actor004,"Normal")

	--★★マルディサント★★:オニーサン、今日はアタシの代役だ<br>騎士役…ちょっとやってみろよ
	Talk(Actor004,"CHRNAME_MALADISANT","speech","L","MA_01A110_330032")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	open_select_window_tag(Actor001,"Normal","MA_01A110_330034","MA_01A110_330035","MA_01A110_330036")
	if is_select(1) then
		goto Block1_1
	elseif is_select(2) then
		goto Block1_2
	elseif is_select(3) then
		goto Block1_3
	end

::Block1_1::
	CloseTalkWindow()
-- ▼直接出力
 --PlayPartVoice("ノワール", "照れ")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:な、なんで俺が…？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01A110_330038")

-- ▼直接出力
CloseTalkWindow()
keep_delay_ik_lookat(Actor005,Actor001,"J_Head",1.0)
-- ▲直接出力
-- ▼直接出力
 --PlayPartVoice("エレイン", "驚き")
-- ▲直接出力
	change_face(Actor005,"Surprise")

	--★★エレイン★★:せ、先輩…！<br>聞いていなかったんですか？
	Talk(Actor005,"CHRNAME_ELAINE","speech","L","MA_01A110_330039")

-- ▼直接出力
 --PlayPartVoice("ノワール", "悩む")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:なにを…？？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01A110_330040")

	PlayAction(Actor005,"to  Std_Surp")
-- ▼直接出力
 --PlayPartVoice("エレイン", "激怒")
-- ▲直接出力
	change_face(Actor005,"Anger")

	--★★エレイン★★:演出家は<br>ギネヴィア様のリアルが欲しいんですよ！？
	Talk(Actor005,"CHRNAME_ELAINE","speech","L","MA_01A110_330041")

	change_face(Actor005,"Anger")

	--★★エレイン★★:ギネヴィア様のリアルなお相手は<br>いったい誰です！？
	Talk(Actor005,"CHRNAME_ELAINE","speech","L","MA_01A110_330042")

	play_head_motion(Actor003, "No", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("ディナタン", "悩む")
-- ▲直接出力
	change_face(Actor003,"Sad")

	--★★ディナタン★★:エレインも感化されている…<br>この空気怖い…
	Talk(Actor003,"CHRNAME_DINATAN","speech","L","MA_01A110_330043")

	goto Block1end

::Block1_2::
	CloseTalkWindow()
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
keep_delay_ik_lookat(Actor001,Actor002,"J_Head",1.0)
 --PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:ギネヴィアが望むなら、やるよ…！
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01A110_330045")

-- ▼直接出力
set_enable_auto_lookat(Actor004,true)
-- ▲直接出力
-- ▼直接出力
 --PlayPartVoice("ギネヴィア", "驚き")
-- ▲直接出力
	change_face(Actor002,"Surprise")

	--★★ギネヴィア★★:…わたしの、リアル
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","MA_01A110_330046")

-- ▼直接出力
set_enable_auto_lookat(Actor004,false)
-- ▲直接出力
	play_head_motion(Actor004, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("マルディサント", "激怒")
-- ▲直接出力
	change_face(Actor004,"Anger")

	--★★マルディサント★★:そーだ！！アンタのリアルなお相手は誰だ！？<br>アンタが心から言葉を尽くせる相手は！？
	Talk(Actor004,"CHRNAME_MALADISANT","speech","L","MA_01A110_330047")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
keep_delay_ik_lookat(Actor002,Actor001,"J_Head",1.0)
 --PlayPartVoice("ギネヴィア", "肯定")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★ギネヴィア★★:………ノワール、おねがい
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","MA_01A110_330048")

	goto Block1end

::Block1_3::
	CloseTalkWindow()
-- ▼直接出力
set_enable_auto_lookat(Actor001,true)
set_enable_auto_lookat(Actor002,true)
-- ▲直接出力
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("ノワール", "笑い")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★ノワール★★:どうせやるなら王女役がいいな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01A110_330050")

-- ▼直接出力
 --PlayPartVoice("ギネヴィア", "驚き")
-- ▲直接出力
	change_face(Actor002,"Surprise")

	--★★ギネヴィア★★:ならわたしが騎士役をやれって？
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","MA_01A110_330051")

	change_face(Actor004,"Normal")

	--★★マルディサント★★:役をシャッフルさせて練習する方法も<br>一応なくはねえがよ…
	Talk(Actor004,"CHRNAME_MALADISANT","speech","L","MA_01A110_330052")

	play_head_motion(Actor004, "No", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("マルディサント", "怒り")
-- ▲直接出力
	change_face(Actor004,"Anger")

	--★★マルディサント★★:時間ねえ中でやるもんじゃねえんだよ<br>芝居ナメてんのか？演出家ナメてんのか？お？
	Talk(Actor004,"CHRNAME_MALADISANT","speech","L","MA_01A110_330053")

-- ▼直接出力
keep_delay_ik_lookat(Actor003,Actor001,"J_Head",1.0)
 --PlayPartVoice("ディナタン", "否定")
-- ▲直接出力
	change_face(Actor003,"Surprise")

	--★★ディナタン★★:に、に、兄さん、駄目だよ…！<br>マァルはお芝居に関して冗談通じないんだから
	Talk(Actor003,"CHRNAME_DINATAN","speech","L","MA_01A110_330054")

	goto Block1end

::Block1end::
-- ▼直接出力
set_enable_auto_lookat(Actor001,true)
set_enable_auto_lookat(Actor002,true)
-- ▲直接出力
	play_head_motion(Actor004, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("マルディサント", "気合い")
-- ▲直接出力
	change_face(Actor004,"Anger")

	--★★マルディサント★★:やるぞ！覚悟決めろよ！死ぬなら舞台上で死ね！<br>いや、客の心臓握りつぶす気で行け！！
	Talk(Actor004,"CHRNAME_MALADISANT","speech","L","MA_01A110_330056")


	--★★マルディサント★★:稽古は反復！特にトーシロはな！！<br>ほら、オニーサン！台本持ちな！
	Talk(Actor004,"CHRNAME_MALADISANT","speech","L","MA_01A110_330057")

-- ▼直接出力
set_enable_auto_lookat(Actor001,false)
set_enable_auto_lookat(Actor002,false)
-- ▲直接出力
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:わ、わかった
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01A110_330058")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	play_head_motion(Actor004, "Nod", 0.3, 1.0, false)

	--★★マルディサント★★:いくぞ！まずは出会いのシーンから――
	Talk(Actor004,"CHRNAME_MALADISANT","speech","L","MA_01A110_330060")

	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	InitializeLoad_Preload()
	load_area_scene_preload(115020)
	InitializeCharacter_3D_Preload("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101011","001","101011001","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("101012","001","101012001","content_animationpack__common","FacialPack","Actor003")
	InitializeCharacter_3D_Preload("101017","001","101017001","content_animationpack__common","FacialPack","Actor004")
	InitializeCharacter_3D_Preload("101030","001","101030001","content_animationpack__common","FacialPack","Actor005")
	InitializeCharacter_3D_Preload("101016","001","101016001","content_animationpack__common","FacialPack","Actor006")
	load_head_animation_preload(Actor006,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor004,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor003,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110011_07)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
