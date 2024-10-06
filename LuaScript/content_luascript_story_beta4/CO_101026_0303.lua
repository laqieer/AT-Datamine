-- このluaスクリプトは、CO_101026_0303.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110111_02","110111_02_h")
Include("content_adv_advsmall_110111_02","Template110111_02_h")
Include("content_adv_advsmall_110111_03","110111_03_h")
Include("content_adv_advsmall_110111_03","Template110111_03_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos110111_02_001,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName110111_02,CameraPos110111_02_001)
	Camera002 = SetTemplate("Actor002",nil,CharaPos110111_02_006,"content_motion3d_advarea_common_adv_templatecontroller","Chr_008_01_StdController","to Std_Loop",CameraAssetBundleName110111_02,CameraPos110111_02_006)
	Camera003 = SetTemplate("Actor003",16.5,CharaPos110111_02_002,"content_motion3d_advarea_common_adv_templatecontroller","Npc_001_01_StdController","to Std_Loop",CameraAssetBundleName110111_02,CameraPos110111_02_002)
	Camera004 = SetTemplate("Actor004",53.5,CharaPos110111_02_003,"content_motion3d_advarea_common_adv_templatecontroller","Npc_001_01_StdController","to Std_Loop",CameraAssetBundleName110111_02,CameraPos110111_02_003)
	Camera005 = SetTemplate("Actor005",-160,CharaPos110111_02_005,"content_motion3d_advarea_common_adv_templatecontroller","Npc_023_01_StdController","to Std_Loop",CameraAssetBundleName110111_02,CameraPos110111_02_005)
	Camera006 = SetTemplate("Actor006",nil,CharaPos110111_02_007,"content_motion3d_advarea_common_adv_templatecontroller","Npc_510_01_StdController","to Std_Loop",CameraAssetBundleName110111_02,CameraPos110111_02_007)
	Camera007 = SetTemplate("Actor007",-48,CharaPos110111_02_004,"content_motion3d_advarea_common_adv_templatecontroller","Npc_023_02_StdController","to Std_Loop",CameraAssetBundleName110111_02,CameraPos110111_02_004)
	InitializeTemplateRandomCamera110111_02()
	InitializeTemplate110111_02()
-- ▼直接出力
set_enable_auto_lookat(Actor001, false)
-- ▲直接出力
-- ▼直接出力
set_enable_auto_lookat(Actor003, false)
-- ▲直接出力
-- ▼直接出力
set_enable_auto_lookat(Actor004, false)
-- ▲直接出力
end
function template2()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos110111_03_002,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName110111_03,CameraPos110111_03_002)
	Camera002 = SetTemplate("Actor002",nil,CharaPos110111_03_006,"content_motion3d_advarea_common_adv_templatecontroller","Chr_008_01_StdController","to Std_Loop",CameraAssetBundleName110111_03,CameraPos110111_03_006)
	Camera003 = SetTemplate("Actor003",nil,CharaPos110111_03_001,"content_motion3d_advarea_common_adv_templatecontroller","Npc_001_01_StdController","to Std_Loop",CameraAssetBundleName110111_03,CameraPos110111_03_001)
	Camera004 = SetTemplate("Actor004",nil,CharaPos110111_03_003,"content_motion3d_advarea_common_adv_templatecontroller","Npc_001_01_StdController","to Std_Loop",CameraAssetBundleName110111_03,CameraPos110111_03_003)
	InitializeTemplateRandomCamera110111_03()
	InitializeTemplate110111_03()
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(110111)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101026","001","101026001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("401007","001","401007001","content_animationpack__common","FacialPack","Actor003")
	Actor004 = InitializeCharacter_3D("401009","001","401009001","content_animationpack__common","FacialPack","Actor004")
	Actor005 = InitializeCharacter_3D("401023","001","401023001","content_animationpack__common","FacialPack","Actor005")
	Actor006 = InitializeCharacter_3D("401024","001","401024001","content_animationpack__common","FacialPack","Actor006")
	Actor007 = InitializeCharacter_3D("401025","001","401025001","content_animationpack__common","FacialPack","Actor007")
	template1()
	load_head_animation(Actor003,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor004,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor005,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

-- ▼直接出力
PlayPartVoice("ノワール", "肯定3")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:パーシヴァルのやつ<br>貴族の人たちと普通に話してる…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101026_03030002")

	change_face(Actor001,"Normal")

	--★★ノワール★★:貴族っていうの、自称じゃなかったんだな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101026_03030003")

-- ▼直接出力
lookat_delay_weight(Actor004, {1.0, 0.08, 0.4, 0.2} , 1.0)
keep_ik_lookat(Actor004, Actor001, "J_Head")
-- ▲直接出力
	PlayAction(Actor004,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("男子1", "肯定")
-- ▲直接出力

	--★★キャメロット騎士学術院（男）③★★:疑ってたのか？<br>パーシヴァルくんは正真正銘の貴族さ
	Talk(Actor004,"NPCNAME_0246","speech","L","CO_101026_03030004")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	play_head_motion(Actor003, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("男子2", "肯定2")
-- ▲直接出力

	--★★キャメロット騎士学術院（男）②★★:貴族というよりも<br>王族が正しいね
	Talk(Actor003,"NPCNAME_0243","speech","L","CO_101026_03030005")

-- ▼直接出力
SkipDefaultMotion(Actor005)
PlayActionDirect(Actor005,"to  Std_Talk")
keep_ik_lookat(Actor001, Actor003, "J_Head")
lookat_delay_weight(Actor001, {1.0, 0.08, 0.4, 0.2} , 1.0)
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("ノワール", "驚き")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:王族だって？<br>パーシヴァルが？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101026_03030006")

-- ▼直接出力
keep_ik_lookat(Actor003, Actor001, "J_Head")
lookat_delay_weight(Actor003, {1.0, 0.08, 0.4, 0.2} , 1.0)
-- ▲直接出力
	play_head_motion(Actor003, "Nod", 0.3, 1.0, false)

	--★★キャメロット騎士学術院（男）②★★:そう。島の東部にある…<br>いや、正確には「あった」王国のね
	Talk(Actor003,"NPCNAME_0243","speech","L","CO_101026_03030007")

-- ▼直接出力
SkipDefaultMotion(Actor006)
PlayActionDirect(Actor006,"to  Std_Talk")
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("男子2", "落胆")
-- ▲直接出力

	--★★キャメロット騎士学術院（男）②★★:数年前にあったバルバロイ襲撃事件で<br>パーシヴァルくんの母上である王妃様が亡くなり
	Talk(Actor003,"NPCNAME_0243","speech","L","CO_101026_03030008")


	--★★キャメロット騎士学術院（男）②★★:国王様やその他の親族も行方不明
	Talk(Actor003,"NPCNAME_0243","speech","L","CO_101026_03030009")

	PlayAction(Actor003,"to  Std_Talk")

	--★★キャメロット騎士学術院（男）②★★:その影響で国民も<br>大半が国を出て行ってしまったのさ
	Talk(Actor003,"NPCNAME_0243","speech","L","CO_101026_03030011")

-- ▼直接出力
setup_small_camera_end()
lookat_delay_weight_reset(Actor001 , 0.6)
SkipDefaultMotion(Actor007)
PlayActionDirect(Actor007,"to  Std_Talk")
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("ノワール", "落胆")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:そうだったのか…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101026_03030012")

	PlayAction(Actor001,"to  Std_Worry")
	change_face(Actor001,"Normal")

	--★★ノワール★★:ん？パーシヴァルが王族ってことは<br>ディンドランさんもってことだよな？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101026_03030013")

	play_head_motion(Actor004, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("男子1", "肯定3")
-- ▲直接出力

	--★★キャメロット騎士学術院（男）③★★:そう<br>ディンドランさんは義理の姉にあたる
	Talk(Actor004,"NPCNAME_0246","speech","L","CO_101026_03030014")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力

	--★★ノワール★★:さっき、ひとつ気になったんだけどさ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101026_03030015")

-- ▼直接出力
play_head_motion(Actor006, "Nod", 0.3, 1.0, false)
-- ▲直接出力

	--★★ノワール★★:パーシヴァルってディンドランさんに<br>いつもあんな態度なのか？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101026_03030016")

-- ▼直接出力
PlayActionDirect(Actor005,"to  Std_Talk")
-- ▲直接出力

	--★★ノワール★★:すごく心配してくれてるのに<br>冷たくあしらってた
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101026_03030017")

-- ▼直接出力
lookat_delay_weight_reset(Actor004 , 0.6)
PlayActionDirect(Actor004,"to  Std_Sad02")
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("男子1", "悩む")
-- ▲直接出力
	change_face(Actor004,"Sad")

	--★★キャメロット騎士学術院（男）③★★:ああ、まあ…
	Talk(Actor004,"NPCNAME_0246","speech","L","CO_101026_03030018")

-- ▼直接出力
lookat_delay_weight_reset(Actor003 , 0.6)
PlayActionDirect(Actor003,"to  Std_Worry")
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("男子2", "悩む")
-- ▲直接出力

	--★★キャメロット騎士学術院（男）②★★:昔はパーシヴァルくんも<br>ディンドランさんにべったりだったんだけどね
	Talk(Actor003,"NPCNAME_0243","speech","L","CO_101026_03030020")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "納得")
-- ▲直接出力

	--★★ノワール★★:そっか<br>いろいろあるよな、姉弟も
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101026_03030022")

-- ▼直接出力
keep_ik_lookat(Actor001, Actor003, "J_Head")
lookat_delay_weight(Actor001, {1.0, 0.08, 0.4, 0.2} , 1.0)
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Talk")

	--★★ノワール★★:ところで、ダニーとジャンは<br>やけにパーシヴァルのことが詳しいんだな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101026_03030023")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	play_head_motion(Actor003, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("男子2", "笑い")
-- ▲直接出力

	--★★キャメロット騎士学術院（男）②★★:僕たちは小さい頃から<br>いつも３人一緒なんだ
	Talk(Actor003,"NPCNAME_0243","speech","L","CO_101026_03030024")

	play_head_motion(Actor004, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("男子1", "肯定2")
-- ▲直接出力
	change_face(Actor004,"Normal")

	--★★キャメロット騎士学術院（男）③★★:パーシヴァルくんがここに来るってなったときに<br>俺たちもついてきたのさ
	Talk(Actor004,"NPCNAME_0246","speech","L","CO_101026_03030025")

	open_select_window_tag(Actor001,"Normal","CO_101026_03030027","CO_101026_03030028")
	if is_select(1) then
		goto Block1_1
	elseif is_select(2) then
		goto Block1_2
	end

::Block1_1::
	CloseTalkWindow()
-- ▼直接出力
PlayPartVoice("ノワール", "驚き")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:パーシヴァルにくっついて<br>学園に入学までしたのか？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101026_03030030")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
	change_face(Actor001,"Surprise")

	--★★ノワール★★:なんというか<br>付き人の鑑だな、ふたりとも
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101026_03030031")

-- ▼直接出力
keep_ik_lookat(Actor004, Actor001, "J_Head")
lookat_delay_weight(Actor004, {1.0, 0.08, 0.4, 0.2} , 1.0)
-- ▲直接出力
	PlayAction(Actor004,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("男子1", "笑い")
-- ▲直接出力
	change_face(Actor004,"Smile")

	--★★キャメロット騎士学術院（男）③★★:サンキュー<br>そう言ってもらえると嬉しい
	Talk(Actor004,"NPCNAME_0246","speech","L","CO_101026_03030032")

-- ▼直接出力
keep_ik_lookat(Actor003, Actor001, "J_Head")
lookat_delay_weight(Actor003, {1.0, 0.08, 0.4, 0.3} , 1.0)
-- ▲直接出力
	play_head_motion(Actor003, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("男子2", "笑い")
-- ▲直接出力
	change_face(Actor003,"Smile")

	--★★キャメロット騎士学術院（男）②★★:初めて言われたかもしれないな、そんなこと
	Talk(Actor003,"NPCNAME_0243","speech","L","CO_101026_03030033")

	goto Block1end

::Block1_2::
	CloseTalkWindow()
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "笑い")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★ノワール★★:そっか<br>友達なんだな、３人は
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101026_03030035")

-- ▼直接出力
keep_ik_lookat(Actor004, Actor003, "J_Head")
lookat_delay_weight(Actor004, {1.0, 0.08, 0.4, 0.2} , 1.0)
-- ▲直接出力
	change_face(Actor004,"Surprise")

	--★★キャメロット騎士学術院（男）③★★:友達？
	Talk(Actor004,"NPCNAME_0246","speech","L","CO_101026_03030036")

-- ▼直接出力
keep_ik_lookat(Actor003, Actor004, "J_Head")
lookat_delay_weight(Actor003, {1.0, 0.08, 0.4, 0.2} , 1.0)
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("男子2", "驚き")
-- ▲直接出力
	change_face(Actor003,"Surprise")

	--★★キャメロット騎士学術院（男）②★★:僕らとパーシヴァルくんが？
	Talk(Actor003,"NPCNAME_0243","speech","L","CO_101026_03030037")

	goto Block1end

::Block1end::
-- ▼直接出力
lookWeight = {0.7, 0.08, 0.7, 0.3}
lookat_delay_weight(Actor002, lookWeight,2)
keep_ik_lookat(Actor002, Actor001, "J_Head")
-- ▲直接出力
	change_face(Actor002,"Surprise")

	--★★パーシヴァル★★:………
	Talk(Actor002,"CHRNAME_PERCIVAL","speech","L","CO_101026_03030039")

-- ▼直接出力
CloseTalkWindow()
lookat_delay_weight_reset(Actor002 , 1)
PlayActionDirect(Actor002,"to  Std_Talk")
turn_chara(Actor002,31.143,0.5)
PlayActionDirect(Actor005,"to Std_Loop")
PlayActionDirect(Actor006,"to Std_Loop")
PlayActionDirect(Actor007,"to Std_Loop")
set_enable_auto_lookat(Actor006, false)
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("パーシヴァル", "納得")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★パーシヴァル★★:パーティ？それはおもしろそうだ<br>友人を連れていってもよいだろうか
	Talk(Actor002,"CHRNAME_PERCIVAL","speech","L","CO_101026_03030041")

	play_head_motion(Actor005, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("貴族_男1", "肯定")
-- ▲直接出力

	--★★貴族（男）★★:どうぞどうぞ。会場は学園の講堂ですし<br>ご学友の方と一緒にいらしてください
	Talk(Actor005,"NPCNAME_0353","speech","L","CO_101026_03030042")

-- ▼直接出力
 --フェードアウト
CloseTalkWindow()
fadeout(0,0,0,1.0, CHARA_IN_IN)
wait_time(CHARA_IN_IN + CHARA_IN_WAIT)
Hide(Actor005)
Hide(Actor006)
Hide(Actor007)
set_enable_auto_lookat_all(true)
turn_chara(Actor001,-65,0)
lookat_delay_weight_reset(Actor001 , 1)
lookat_delay_weight_reset(Actor003 , 1)
lookat_delay_weight_reset(Actor004 , 1)
template2()
wait_time(0.2)
setup_small_camera_start()
 --フェードイン
fadein(CHARA_IN_OUT)
wait_time(CHARA_IN_OUT)
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("パーシヴァル", "笑い")
-- ▲直接出力

	--★★パーシヴァル★★:近々、学園の講堂でパーティが開催されるらしい<br>ダニーとジャン、キミたちも一緒に行こう
	Talk(Actor002,"CHRNAME_PERCIVAL","speech","L","CO_101026_03030044")

	PlayAction(Actor004,"to  Std_Surp")
-- ▼直接出力
set_enable_auto_lookat_all(false)
PlayPartVoice("男子1", "驚き")
-- ▲直接出力
	change_face(Actor004,"Surprise")

	--★★キャメロット騎士学術院（男）③★★:えっ、本当？
	Talk(Actor004,"NPCNAME_0246","speech","L","CO_101026_03030045")

	PlayAction(Actor003,"to  Std_Joy")
-- ▼直接出力
PlayPartVoice("男子2", "肯定3")
-- ▲直接出力
	change_face(Actor003,"Smile")

	--★★キャメロット騎士学術院（男）②★★:やった、ローストポーク食べられるかな！？
	Talk(Actor003,"NPCNAME_0243","speech","L","CO_101026_03030046")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("パーシヴァル", "肯定3")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★パーシヴァル★★:ノワールも来たければ来るといい
	Talk(Actor002,"CHRNAME_PERCIVAL","speech","L","CO_101026_03030048")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★ノワール★★:え？あ、ああ、そうさせてもらおうかな<br>（やっぱり、俺だけみんなと扱いが違うよな…）
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101026_03030049")

-- ▼直接出力
local trustParam = set_communication_rankup("パーシヴァル_コミュランク", "パーシヴァル_親密度")
-- ▲直接出力
-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
-- ▼直接出力
trustParam.UpdateRankup() -- ここまでの上昇値をゲージの変化量に変換
-- ▲直接出力
-- ▼直接出力
open_trust_rank_up(Actor002, trustParam)
-- ▲直接出力
-- ▼直接出力
 --open_trust_gauge(Actor002, trustParam)
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
	InitializeCharacter_3D_Preload("101026","001","101026001","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("401007","001","401007001","content_animationpack__common","FacialPack","Actor003")
	InitializeCharacter_3D_Preload("401009","001","401009001","content_animationpack__common","FacialPack","Actor004")
	InitializeCharacter_3D_Preload("401023","001","401023001","content_animationpack__common","FacialPack","Actor005")
	InitializeCharacter_3D_Preload("401024","001","401024001","content_animationpack__common","FacialPack","Actor006")
	InitializeCharacter_3D_Preload("401025","001","401025001","content_animationpack__common","FacialPack","Actor007")
	load_head_animation_preload(Actor003,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor004,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor005,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110111_02)
	system.PreLoadRequest(CameraAssetBundleName110111_03)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
