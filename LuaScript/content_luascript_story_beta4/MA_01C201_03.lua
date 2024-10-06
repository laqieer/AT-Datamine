-- このluaスクリプトは、MA_01C201_03.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110051_02","110051_02_h")
Include("content_adv_advsmall_110051_02","Template110051_02_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos110051_02_002,"content_motion3d_advarea_common_adv_templatecontroller","Com_m_SitController","to Sit01_Loop",CameraAssetBundleName110051_02,CameraPos110051_02_002)
	Camera002 = SetTemplate("Actor002",nil,CharaPos110051_02_004,"content_motion3d_advarea_common_adv_templatecontroller","Chr_004_01_SitController","to Sit01_Loop",CameraAssetBundleName110051_02,CameraPos110051_02_004)
	Camera003 = SetTemplate("Actor003",nil,CharaPos110051_02_006,"content_motion3d_advarea_common_adv_templatecontroller","Chr_006_01_SitController","to Sit01_Loop",CameraAssetBundleName110051_02,CameraPos110051_02_006)
	Camera004 = SetTemplate("Actor004",nil,CharaPos110051_02_011,"content_motion3d_advarea_common_adv_templatecontroller","Npc_008_01_SitController","to Sit01_Loop",CameraAssetBundleName110051_02,CameraPos110051_02_011)
	Camera005 = SetTemplate("Actor005",nil,CharaPos110051_02_012,"content_motion3d_advarea_common_adv_templatecontroller","Chr_020_01_StdController","to Std_Loop",CameraAssetBundleName110051_02,CameraPos110051_02_012)
	Camera006 = SetTemplate("Actor006",nil,CharaPos110051_02_010,"content_motion3d_advarea_common_adv_templatecontroller","Chr_522_01_SitController","to Sit01_Loop",CameraAssetBundleName110051_02,CameraPos110051_02_010)
	InitializeTemplateRandomCamera110051_02()
	InitializeTemplate110051_02()
-- ▼直接出力
setup_template_moveobj_110051_02()
DontCameraOffset(Actor001)
-- ▲直接出力
-- ▼直接出力
DontCameraOffset(Actor002)
-- ▲直接出力
-- ▼直接出力
DontCameraOffset(Actor003)
-- ▲直接出力
-- ▼直接出力
DontCameraOffset(Actor004)
-- ▲直接出力
-- ▼直接出力
DontCameraOffset(Actor006)
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(115060)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101014","001","101014001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("101022","001","101022001","content_animationpack__common","FacialPack","Actor003")
	Actor004 = InitializeCharacter_3D("101040","001","101040001","content_animationpack__common","FacialPack","Actor004")
	Actor005 = InitializeCharacter_3D("101051","001","101051001","content_animationpack__common","FacialPack","Actor005")
	Actor006 = InitializeCharacter_3D("101032","001","101032001","content_animationpack__common","FacialPack","Actor006")
	Actor007 = InitializeCharacter_TextOnly()
	template1()
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor003,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor005,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor004,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

-- ▼直接出力
 --PlayPartVoice("トリスタン", "落胆")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★トリスタン★★:年が明けたわけだけど…<br>なんて挨拶すればいいんだろうね
	Talk(Actor002,"CHRNAME_TRISTAN","speech","L","MA_01C201_030002")

-- ▼直接出力
 --PlayPartVoice("モルドレッド", "笑い")
-- ▲直接出力

	--★★モルドレッド★★:さぁな<br>めでたくねえのは確かだぜ
	Talk(Actor003,"CHRNAME_MORDRED","speech","L","MA_01C201_030003")


	--★★モルドレッド★★:最強騎士まで向こうについて？<br>で、そいつをぶっ倒して？
	Talk(Actor003,"CHRNAME_MORDRED","speech","L","MA_01C201_030004")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力

	--★★モルドレッド★★:そのうえ、聖杯がアーサーのヤロウに<br>ぶっ壊されたってんだからな
	Talk(Actor003,"CHRNAME_MORDRED","speech","L","MA_01C201_030005")

-- ▼直接出力
 --PlayPartVoice("トリスタン", "挨拶")
-- ▲直接出力

	--★★トリスタン★★:アーサーはどうして<br>聖杯を壊したりしたんだろう
	Talk(Actor002,"CHRNAME_TRISTAN","speech","L","MA_01C201_030006")

-- ▼直接出力
 --PlayPartVoice("ルーシャス", "悩む")
-- ▲直接出力

	--★★ルーシャス★★:さて、なぜであろうな
	Talk(Actor005,"CHRNAME_LUCIUS","speech","L","MA_01C201_030007")


	--★★ルーシャス★★:今は聖杯によってアーサーが<br>さらに力を得ることがなかったのを喜ぶべきか
	Talk(Actor005,"CHRNAME_LUCIUS","speech","L","MA_01C201_030008")

	PlayAction(Actor005,"to  Std_Worry")
	change_face(Actor005,"Surprise")

	--★★ルーシャス★★:…いや、そもそも奴は<br>聖杯を必要となどしていなかったのか
	Talk(Actor005,"CHRNAME_LUCIUS","speech","L","MA_01C201_030009")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("ノワール", "肯定")
-- ▲直接出力

	--★★ノワール★★:…ランスロットは言ってた
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01C201_030011")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)

	--★★ノワール★★:アーサーはすべてをやり直すために<br>伝説にまつわるすべてを破壊するんだって
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01C201_030012")

-- ▼直接出力
 --PlayPartVoice("ノワール", "落胆")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:聖杯や継承者、GSに頼らず<br>自分たちの力だけで世界を守るって
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01C201_030013")

-- ▼直接出力
 --PlayPartVoice("モルドレッド", "肯定2")
-- ▲直接出力

	--★★モルドレッド★★:そんな大それたことが自分に出来るってか<br>ずいぶんな自信だよなァ
	Talk(Actor003,"CHRNAME_MORDRED","speech","L","MA_01C201_030018")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	change_face(Actor003,"Sad")

	--★★モルドレッド★★:…ま、言ってることの意味は<br>わかんなくもねえけどよ
	Talk(Actor003,"CHRNAME_MORDRED","speech","L","MA_01C201_030019")

	change_face(Actor003,"Normal")

	--★★モルドレッド★★:不確かなものは信じられんねえ、全部ウソくせえ<br>伝説も言い伝えも家族やダチとの絆ってやつも
	Talk(Actor003,"CHRNAME_MORDRED","speech","L","MA_01C201_030020")

	play_head_motion(Actor003, "Nod", 0.3, 1.0, false)

	--★★モルドレッド★★:そんなモンに頼らなくて済むなら<br>そのほうがイイに決まってる
	Talk(Actor003,"CHRNAME_MORDRED","speech","L","MA_01C201_030021")

-- ▼直接出力
 --PlayPartVoice("トリスタン", "落胆")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★トリスタン★★:けど…そのために全部破壊することが<br>本当に正しいと思っているのかな
	Talk(Actor002,"CHRNAME_TRISTAN","speech","L","MA_01C201_030022")

	PlayAction(Actor005,"to  Std_Talk")
	change_face(Actor005,"Normal")

	--★★ルーシャス★★:破壊無くして創造無し<br>という考えもある
	Talk(Actor005,"CHRNAME_LUCIUS","speech","L","MA_01C201_030023")

-- ▼直接出力
 --PlayPartVoice("ルーシャス", "笑い")
-- ▲直接出力

	--★★ルーシャス★★:王はときに大胆な一手が求められるものだ
	Talk(Actor005,"CHRNAME_LUCIUS","speech","L","MA_01C201_030024")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
-- ▼直接出力
 --PlayPartVoice("トリスタン", "怒り")
-- ▲直接出力

	--★★トリスタン★★:…キミ、どっちの味方なわけ？
	Talk(Actor002,"CHRNAME_TRISTAN","speech","L","MA_01C201_030025")

	play_head_motion(Actor005, "Nod", 0.3, 1.0, false)

	--★★ルーシャス★★:あくまで余の見解を述べただけだ
	Talk(Actor005,"CHRNAME_LUCIUS","speech","L","MA_01C201_030026")


	--★★トリスタン★★:…まあ、いいけど
	Talk(Actor002,"CHRNAME_TRISTAN","speech","L","MA_01C201_030028")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
-- ▼直接出力
 --PlayPartVoice("トリスタン", "肯定")
-- ▲直接出力

	--★★トリスタン★★:どちらにせよ、聖杯が破壊されたのが事実なら<br>バルバロイの根絶を願うことはもう不可能だよね
	Talk(Actor002,"CHRNAME_TRISTAN","speech","L","MA_01C201_030029")


	--★★トリスタン★★:残された『伝説』は<br>継承者だけになったわけだけど…？
	Talk(Actor002,"CHRNAME_TRISTAN","speech","L","MA_01C201_030030")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	open_select_window_tag(Actor001,"Normal","MA_01C201_030031","MA_01C201_030032")
	if is_select(1) then
		goto Block1_1
	elseif is_select(2) then
		goto Block1_2
	end

::Block1_1::
	CloseTalkWindow()
-- ▼直接出力
 --PlayPartVoice("ノワール", "落胆")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:聖杯なしでバルバロイを根絶できるんだろうか
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01C201_030034")

	change_face(Actor001,"Sad")

	--★★ノワール★★:俺の…継承者の力だけで<br>バルバロイを根絶できるんだろうか
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01C201_030035")

-- ▼直接出力
 --PlayPartVoice("モルドレッド", "挨拶")
-- ▲直接出力
	change_face(Actor003,"Normal")

	--★★モルドレッド★★:考えてわかることじゃねえだろ<br>とにかく今は態勢を立て直すことが先決だ
	Talk(Actor003,"CHRNAME_MORDRED","speech","L","MA_01C201_030036")

	goto Block1end

::Block1_2::
	CloseTalkWindow()
-- ▼直接出力
 --PlayPartVoice("ノワール", "落胆")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:聖杯もそうだけど…<br>ギネヴィアの行方が気になる
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01C201_030038")

-- ▼直接出力
 --PlayPartVoice("ケイ", "落胆")
-- ▲直接出力
	change_face(Actor004,"Sad")

	--★★ケイ★★:兵を出してはいるのだが<br>足取りが一向につかめなくてな
	Talk(Actor004,"CHRNAME_KAY","speech","L","MA_01C201_030039")

-- ▼直接出力
 --PlayPartVoice("ルーシャス", "肯定")
-- ▲直接出力
	change_face(Actor005,"Normal")

	--★★ルーシャス★★:我が国の諜報部を手配している<br>捜査がはじまれば、すぐに見つけ出せるだろう
	Talk(Actor005,"CHRNAME_LUCIUS","speech","L","MA_01C201_030040")

	play_head_motion(Actor004, "Nod", 0.3, 1.0, false)
	change_face(Actor004,"Normal")

	--★★ケイ★★:協力、痛み入る
	Talk(Actor004,"CHRNAME_KAY","speech","L","MA_01C201_030041")

	PlayAction(Actor005,"to  Std_Worry")
-- ▼直接出力
 --PlayPartVoice("ルーシャス", "笑い")
-- ▲直接出力
	change_face(Actor005,"Normal")

	--★★ルーシャス★★:この国の顔を立ててやるために<br>あまり出しゃばらないつもりだったのだがな
	Talk(Actor005,"CHRNAME_LUCIUS","speech","L","MA_01C201_030042")

-- ▼直接出力
 --PlayPartVoice("モルドレッド", "怒り")
-- ▲直接出力
	change_face(Actor003,"Normal")

	--★★モルドレッド★★:いちいち<br>ひとこと多いんだよ、てめえは
	Talk(Actor003,"CHRNAME_MORDRED","speech","L","MA_01C201_030043")

	goto Block1end

::Block1end::
-- ▼直接出力
set_enable_auto_lookat(Actor001, false)
set_enable_auto_lookat(Actor005, false)
lookWeight = {0.9, 0, 0.5, 0.35}
keep_ik_lookat(Actor005, Actor001, "J_Head")
lookat_delay_weight(Actor005, lookWeight,0.4)
keep_delay_ik_lookat(Actor001, Actor005, "J_Head",0.7)
lookat_delay_weight(Actor001, 0.9,0,0.5,0.5,0.4)
-- ▲直接出力
-- ▼直接出力
 --PlayPartVoice("ルーシャス", "悩む")
-- ▲直接出力
	change_face(Actor005,"Normal")

	--★★ルーシャス★★:して、継承者よ
	Talk(Actor005,"CHRNAME_LUCIUS","speech","L","MA_01C201_030045")

	change_face(Actor001,"Normal")

	--★★ノワール★★:なんだ？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01C201_030046")

-- ▼直接出力
 --PlayPartVoice("ルーシャス", "肯定")
-- ▲直接出力

	--★★ルーシャス★★:いざというときに刃こぼれなどあっては<br>目も当てられん。武器の手入れを怠らずにな
	Talk(Actor005,"CHRNAME_LUCIUS","speech","L","MA_01C201_030047")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
	change_face(Actor001,"Surprise")

	--★★ノワール★★:え？<br>あ、ああ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01C201_030049")

	change_face(Actor004,"Normal")

	--★★ケイ★★:皆、当面のあいだはギネヴィアの行方を探りつつ<br>学園の守りを固めること力を注いでくれ
	Talk(Actor004,"CHRNAME_KAY","speech","L","MA_01C201_030050")

-- ▼直接出力
CloseTalkWindow()
fadeout(0,0,0,1.0, CHARA_IN_IN)
wait_time(CHARA_IN_IN + CHARA_IN_WAIT)
lookat_weight_reset(Actor001)
Hide(Actor003)
Hide(Actor005)
Hide(Actor002)

set_pos(Chair_10, {-4.236, 0.037, 2.368}) --モルドレッドの椅子を大人しくする
set_rot(Chair_10, {0, -83.1, 0})

set_animationcontroller(Actor001, "Chr_002_01_StdController", "to Std_Loop")
set_animationcontroller(Actor004, "Npc_008_01_StdController", "to Std_Loop")
Camera001 = setup_small_camera_resetting(Actor001,CharaPos020,CameraPos020)
Camera004 = setup_small_camera_resetting(Actor004,CharaPos021,CameraPos021)

setup_small_camera_start(RndCamera009)
 --フェードイン
fadein(CHARA_IN_OUT)
wait_time(CHARA_IN_OUT)
wait_time(0.6)
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:なぁ…ひとつ聞いていいか
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01C201_030052")

	play_head_motion(Actor004, "Nod", 0.3, 1.0, false)
-- ▼直接出力
lookat_delay_weight(Actor004, 1.0, 0, 0.5, 0.2,1.0)
keep_ik_lookat(Actor004,Actor001,"J_Head")
 --PlayPartVoice("ケイ", "肯定")
-- ▲直接出力

	--★★ケイ★★:ん？なんだろうか
	Talk(Actor004,"CHRNAME_KAY","speech","L","MA_01C201_030053")


	--★★ノワール★★:ランスロットが言ってたんだ<br>「アーサーにはモルガン以外にも姉がいる」って
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01C201_030054")

-- ▼直接出力
 --PlayPartVoice("ケイ", "驚き")
-- ▲直接出力
	change_face(Actor004,"Surprise")

	--★★ケイ★★:モルガン以外のアーサーの姉？<br>そんな話は聞いたことがないが…
	Talk(Actor004,"CHRNAME_KAY","speech","L","MA_01C201_030055")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力

	--★★ノワール★★:そうか…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01C201_030056")

-- ▼直接出力
CloseTalkWindow()
fadeout(0,0,0,1.0, CHARA_IN_IN)
wait_time(CHARA_IN_IN + CHARA_IN_WAIT)
Hide(Actor004)
setup_small_camera_start(RndCamera009)
lookat_weight_reset(Actor001)
 --フェードイン
fadein(CHARA_IN_OUT)
wait_time(CHARA_IN_OUT)
wait_time(1.3)
-- ▲直接出力
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)

	--★★ノワール★★:ずっと『本当』が知りたかった
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01C201_030058")

-- ▼直接出力
 --PlayPartVoice("ノワール", "落胆")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:なのに今は、知るのが怖い<br>知ってはいけない気がする
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01C201_030059")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
-- ▼直接出力
bgm_play("Stop_BGM_Bus_LongFade")
-- ▲直接出力
-- ▼直接出力
SkipDefaultMotion(Actor001)
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Sad01")
	change_face(Actor001,"Normal")

	--★★ノワール★★:それでも――
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01C201_030060")

-- ▼直接出力
setup_small_camera_start(RndCamera008)
-- ▲直接出力

	--★★テロップ★★:真実に辿り着けばすべてが分かる<br>なにが間違いだったかも?
	Talk(Actor007,"telop","narration","N","MA_01C201_030061")

	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	InitializeLoad_Preload()
	load_area_scene_preload(115060)
	InitializeCharacter_3D_Preload("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101014","001","101014001","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("101022","001","101022001","content_animationpack__common","FacialPack","Actor003")
	InitializeCharacter_3D_Preload("101040","001","101040001","content_animationpack__common","FacialPack","Actor004")
	InitializeCharacter_3D_Preload("101051","001","101051001","content_animationpack__common","FacialPack","Actor005")
	InitializeCharacter_3D_Preload("101032","001","101032001","content_animationpack__common","FacialPack","Actor006")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor003,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor005,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor004,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110051_02)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
